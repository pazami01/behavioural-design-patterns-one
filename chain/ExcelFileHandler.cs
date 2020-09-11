using System;

namespace worksheet_eight_behavioural_design_patterns
{
    public class ExcelFileHandler : IHandler
    {
        public ExcelFileHandler(string textHandler)
        {
            HandlerName = textHandler;
        }

        public IHandler Handler { get; set; }
        public string HandlerName { get; }
        public void Process(object file)
        {
            File fileObj = (File)file;

            if (fileObj.Type.Equals("excel"))
            {
                Console.WriteLine($"Process and saving excel file... by {HandlerName}");
            }
            else
            {
                if (Handler != null)
                {
                    Console.WriteLine($"{HandlerName} forwards request to {Handler.HandlerName}");
                    Handler.Process(file);
                }
                else
                {
                    Console.WriteLine("File not supported");
                }
            }
        }
    }
}