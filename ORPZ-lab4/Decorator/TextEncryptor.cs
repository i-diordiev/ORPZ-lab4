namespace ORPZ_lab4.Decorator
{
    public class TextEncryptor : TextTransformer
    {
        public TextEncryptor(BaseWriter writer, string data) : base(writer, data)
        {
        }

        public override void DoTransformation()
        {
            var helper = new EncryptionHelper();
            Data = helper.Encrypt(Data);
        }
    }
}