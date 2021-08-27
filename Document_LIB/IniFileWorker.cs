using System.IO;

namespace Loger_app
{
    public class IniFileWorker : IFileWorker
    {
        public Document Create()
        {
            return new IniDocument();
        }

        public Document Open(string path)
        {
            using var file = new StreamReader(path);
            var content = file.ReadToEnd();
            return new IniDocument(path, content);
        }

        public void SaveAs(string path, Document document)
        {
            using var file = new StreamWriter(path, false);
            file.Write(document.Content);
        }

        public void Save(Document document)
        {
            SaveAs(document.Path, document);
        }
    }
}