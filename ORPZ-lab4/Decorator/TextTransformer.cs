namespace ORPZ_lab4.Decorator
{
    public abstract class TextTransformer : BaseWriter
    {
        protected BaseWriter _writer;
        
        protected TextTransformer(BaseWriter writer, string data) : base(data)
        {
            this._writer = writer;
        }

        public override void WriteIntoFile(string fileName)
        {
            if (_writer != null)
            {
                _writer.Data = this.Data;
                _writer.WriteIntoFile(fileName);
            }
        }

        public override string ReadFromFile(string fileName)
        {
            if (_writer != null)
            {
                return _writer.ReadFromFile(fileName);
            }

            return string.Empty;
        }
    }
}