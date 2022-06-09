namespace ORPZ_lab4.Decorator
{
    public abstract class TextTransformer : BaseWriter
    {
        protected BaseWriter _writer;
        
        protected TextTransformer(BaseWriter writer, string data) : base(data)
        {
            this._writer = writer;
        }
    }
}