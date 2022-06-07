namespace ORPZ_lab4.Encryption
{
    public interface IEncryptionFileWriterReader
    {
        void Encrypt(string text, string fileName);
        string Decrypt(string fileName);
    }
}