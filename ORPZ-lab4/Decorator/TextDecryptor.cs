namespace ORPZ_lab4.Decorator
{
    public class TextDecryptor : TextTransformer
    {
        public TextDecryptor(BaseWriter writer, string data) : base(writer, data)
        {
        }

        public override void DoTransformation()
        {
            var helper = new EncryptionHelper();
            _data = helper.Decrypt(_data);
        }
    }
}