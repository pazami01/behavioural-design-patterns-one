namespace command
{
    public class LoggingJob : IJob
    {
        public Logging Logging { set; get; }

        public void Run()
        {
            if (Logging != null)
            {
                Logging.Log();
            }
        }
    }
}