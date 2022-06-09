using System.IO;

namespace ORPZ_lab4.Decorator
{
    public abstract class BaseWriter
    {
        protected string _data;

        public string Data => _data;

        protected BaseWriter(string data)
        {
            _data = data;
        }

        public abstract void DoTransformation();

        public virtual void WriteIntoFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(_data);
            }
        }

        public virtual string ReadFromFile(string fileName)
        {
            string result;
            using (StreamReader sr = new StreamReader(fileName))
            {
                result = sr.ReadToEnd();
            }

            return result;
        }
    }
}