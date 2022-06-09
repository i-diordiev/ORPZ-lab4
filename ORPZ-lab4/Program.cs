using System;
using System.IO;
using ORPZ_lab4.Encryption;
using ORPZ_lab4.Translation;

namespace ORPZ_lab4
{
    // Створити набір класів, котрі реалізують наступні перетворення текстових
    // даних с наступним збереженням в файл:
    // a. Переклад по словам з використанням Google Translate API (робочий
    // приклад можна знати, наприклад, тут
    // https://stackoverflow.com/questions/2246017/using-google-translate-in-c-sharp)
    // b. Шифрування даних будь-яким одним алгоритмом.
    // В програмному застосунку повинні бути реалізовані функції запису
    // текстових даних в файл після використання будь-якої комбінації
    // перетворень в будь-якій послідовності та читання даних з файлу зі
    // зворотнім перетворенням.
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