using Microsoft.VisualBasic;

namespace Loger_app
{
    public interface IFileWorker
    {
        public Document Create();
        public Document Open(string path);

        public void SaveAs(string path,Document document);
        public void Save(Document document);
    }
}