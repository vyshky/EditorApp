using System.IO;

namespace Loger_app
{
    public class JpgFileWorker : IFileWorker
    {
        public Document Create()
        {
            return new JpgDocument();
        }

        public Document Open(string path)
        {
            using var file = File.OpenRead(path);
            var array = new byte[file.Length];
            file.Read(array, 0, array.Length);
            var content =
                System.Text.Encoding.Default
                    .GetString(array); // задает кодировку для массива array и переводит массив в строку
            return new JpgDocument(path, content);
        }

        public void SaveAs(string path, Document document)
        {
            using var file = new FileStream(path, FileMode.OpenOrCreate);
            var array = System.Text.Encoding.Default.GetBytes(document.Content);
            file.Write(array, 0, array.Length);
        }

        public void Save(Document document)
        {
            SaveAs(document.Path, document);
        }
    }
}