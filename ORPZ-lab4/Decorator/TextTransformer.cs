namespace ORPZ_lab4.Decorator
{
    public abstract class TextTransformer : BaseFileWriter
    {
        protected BaseFileWriter FileWriter;
        
        protected TextTransformer(BaseFileWriter fileWriter, string data) : base(data)
        {
            this.FileWriter = fileWriter;
        }

        public override void WriteIntoFile(string fileName)
        {
            if (FileWriter != null)
            {
                FileWriter.Data = this.Data;
                FileWriter.WriteIntoFile(fileName);
            }
        }

        public override string ReadFromFile(string fileName)
        {
            if (FileWriter != null)
            {
                return FileWriter.ReadFromFile(fileName);
            }

            return string.Empty;
        }
    }
}