using System.IO;

namespace ORPZ_lab4.Decorator
{
    public abstract class BaseFileWriter
    {
        public string Data { get; set; }

        protected BaseFileWriter(string data)
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