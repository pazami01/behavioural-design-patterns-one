using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;

namespace command
{
    public class ThreadPool<T> where T: IJob
    {
        private static BlockingCollection<T> jobQueue = new BlockingCollection<T>();
        private Thread[] jobThreads;
        private static bool shutdown;

        public ThreadPool(int numberOfThreads)
        {
            jobThreads = new Thread[numberOfThreads];

            for (var i = 0; i < numberOfThreads; i++)
            {
                Worker worker = new Worker();
                jobThreads[i] = new Thread(worker.Run);
                jobThreads[i].Name = $"Job ID: {i}";
                //throw new System.NotImplementedException();
            }
        }

        public void AddJob(T job)
        {
            jobQueue.Add(job);
        }

        public void ShutdownPool()
        {
            const int sleepTime = 1000;

            while (jobQueue.Count > 0)
            {
                try
                {
                    jobThreads.ToList().ForEach(n => n.Start());
                    Thread.Sleep(sleepTime);
                    //jobThreads[0].Start();
                    //Thread.Sleep(sleepTime);
                    // some code here?
                }
                catch (ThreadInterruptedException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }

            shutdown = true;
            foreach (var workerThread in jobThreads)
            {
                workerThread.Interrupt();
            }
        }

        private class Worker /*(string name)*/ : ThreadLocal<IJob>
        {
            //string _name;

            //Worker(string name)
            //{
            //    _name = name;
            //}
            public void Run()
            {
                while (!shutdown)
                {
                    try
                    {
                        var r = jobQueue.Take();
                        r.Run();
                    }
                    catch (ThreadInterruptedException ex)
                    {
                        Console.WriteLine(ex.StackTrace); //?
                    }
                }
            }
        }
    }
}