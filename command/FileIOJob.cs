namespace command
{
    public class FileIOJob : IJob
    {
        private FileIO _fileIO;

        public void Run()
        {
            if (_fileIO != null)
            {
                _fileIO.Execute();
            }
        }

        public void FileIO(FileIO fileIo) => _fileIO = fileIo;
    }
}