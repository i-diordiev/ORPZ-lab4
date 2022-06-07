using System.IO;

namespace ORPZ_lab4.Encryption
{
    public class EncryptionFileWriterReader : IEncryptionFileWriterReader
    {
        private readonly EncryptionHelper _helper;

        public EncryptionFileWriterReader()
        {
            _helper = new EncryptionHelper();
        }

        public void Encrypt(string text, string fileName)
        {
            var cipheredText = _helper.Encrypt(text);
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write(cipheredText);
            }
        }

        public string Decrypt(string fileName)
        {
            string data;
            using (StreamReader sr = new StreamReader(fileName))
            {
                data = sr.ReadToEnd();
            }

            return _helper.Decrypt(data);
        }
    }
}