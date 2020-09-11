using System;

namespace worksheet_eight_behavioural_design_patterns
{
    public class DocFileHandler : IHandler
    {
        public DocFileHandler(string textHandler)
        {
            HandlerName = textHandler;
        }

        public IHandler Handler { get; set; }
        public string HandlerName { get; }
        public void Process(object file)
        {
            File fileObj = (File)file;

            if (fileObj.Type.Equals("doc"))
            {
                Console.WriteLine($"Process and saving doc file... by {HandlerName}");
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