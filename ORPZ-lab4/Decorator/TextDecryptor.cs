namespace ORPZ_lab4.Decorator
{
    public class TextDecryptor : TextTransformer
    {
        public TextDecryptor(BaseFileWriter fileWriter, string data) : base(fileWriter, data)
        {
        }

        public override void DoTransformation()
        {
            var helper = new EncryptionHelper();
            Data = helper.Decrypt(Data);
        }
    }
}