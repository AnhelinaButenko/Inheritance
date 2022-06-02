using System;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            //DocumentWorker documentWorker = new DocumentWorker();
            DocumentWorker documentWorker;

            Console.WriteLine("Input key");
            string key = Console.ReadLine();

            switch (key)
            {
                case "Pro":
                    documentWorker = new ProDocumentWorker();
                    break;
                case "Exp":
                    documentWorker = new ExpertDocumentWorker();
                    break;
                default:
                    documentWorker = new DocumentWorker();
                    break;
            }

            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();

            //if (key == "Pro" )
            //{
            //    documentWorker = new ProDocumentWorker();
            //    documentWorker.OpenDocument();
            //    documentWorker.EditDocument();
            //    documentWorker.SaveDocument();
            //}
            //else if (key == "Exp" )
            //{
            //    documentWorker = new ExpertDocumentWorker();
            //    documentWorker.OpenDocument();
            //    documentWorker.EditDocument();
            //    documentWorker.SaveDocument();
            //}
            //else
            //{
            //    documentWorker = new DocumentWorker();

            //    documentWorker.OpenDocument();
            //    documentWorker.EditDocument();
            //    documentWorker.SaveDocument();
            //}
        }
    }
}
