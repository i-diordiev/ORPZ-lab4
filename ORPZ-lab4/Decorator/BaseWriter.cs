using System.IO;

namespace ORPZ_lab4.Decorator
{
    public abstract class BaseWriter
    {
        public string Data { get; set; }

        protected BaseWriter(string data)
        {
            Data = data;
        }

        public abstract void DoTransformation();

        public virtual void WriteIntoFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Data);
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