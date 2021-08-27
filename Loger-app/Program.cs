using System;

namespace Loger_app
{
    class Program
    {
        static void Main()
        {
            string path = string.Empty;
            IFileWorker fileWorker = null;
            Document document;

            Console.WriteLine("Выберите какой файл вы хотите открыть");
            Console.WriteLine("1. TXT");
            Console.WriteLine("2. JPEG");
            Console.WriteLine("3. INI");
            var select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    path = @"C:\dir\1.txt";
                    fileWorker = new TxtFileWorker();
                    break;
                case "2":
                    path = @"C:\dir\1.jpg";
                    fileWorker = new JpgFileWorker();
                    break;
                case "3":
                    path = @"C:\dir\1.ini";
                    fileWorker = new IniFileWorker();
                    break;
            }

            document = fileWorker.Open(path);
            Show(document);
        }

        static void Show(Document document)
        {
            var type = document.GetType().FullName;
            switch (type)
            {
                case "Loger_app.IniDocument":
                    ShowINI(document);
                    break;
                case "Loger_app.JpgDocument":
                    ShowJPG(document);
                    break; 
                case "Loger_app.TxtDocument":
                    ShowTXT(document);
                    break;
            }
        }

        static void ShowJPG(Document document)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(document.Content);
            Console.ResetColor();
        }

        static void ShowINI(Document document)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(document.Content);
            Console.ResetColor();
        }

        static void ShowTXT(Document document)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(document.Content);
            Console.ResetColor();
        }
    }
}