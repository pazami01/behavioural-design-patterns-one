using System;

namespace worksheet_eight_behavioural_design_patterns
{
    public class TextFileHandler: IHandler
    {
        public TextFileHandler(string textHandler)
        {
            HandlerName = textHandler;
        }

        public IHandler Handler { get; set; }
        public string HandlerName { get; }
        public void Process(object file)
        {
            File fileObj = (File)file;

            if (fileObj.Type.Equals("text"))
            {
                Console.WriteLine($"Process and saving text file... by {HandlerName}");
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