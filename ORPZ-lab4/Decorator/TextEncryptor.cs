namespace ORPZ_lab4.Decorator
{
    public class TextEncryptor : TextTransformer
    {
        public TextEncryptor(BaseFileWriter fileWriter, string data) : base(fileWriter, data)
        {
        }

        public override void DoTransformation()
        {
            var helper = new EncryptionHelper();
            Data = helper.Encrypt(Data);
        }
    }
}