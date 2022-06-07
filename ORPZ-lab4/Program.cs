using System;
using System.IO;
using ORPZ_lab4.Encryption;
using ORPZ_lab4.Translation;

namespace ORPZ_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string translatedTextFileName = "translated.txt";
            TranslationFileWriter translator = new TranslationFileWriter();
            translator.Translate("apple banana text", "ru", translatedTextFileName);

            string encryptedDataFileName = "encrypted.txt";
            EncryptionFileWriterReader encryptor = new EncryptionFileWriterReader();
            encryptor.Encrypt("test data", encryptedDataFileName);
            
            string decryptedText = encryptor.Decrypt(encryptedDataFileName);
            Console.WriteLine(decryptedText);
        }
    }
}