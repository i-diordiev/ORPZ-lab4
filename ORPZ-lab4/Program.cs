using Google.Cloud.Translation.V2;
using ORPZ_lab4.Decorator;

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
    internal class Program
    {
        private static void Main(string[] args)
        {
            var text = "text";
            BaseFileWriter fileWriter = new FileWriter(text);
            fileWriter.DoTransformation();
            fileWriter.WriteIntoFile("just text.txt");

            fileWriter = new TextTranslator(fileWriter, LanguageCodes.Ukrainian, fileWriter.Data);
            fileWriter.DoTransformation();
            fileWriter.WriteIntoFile("translated text.txt");

            fileWriter = new TextEncryptor(fileWriter, fileWriter.Data);
            fileWriter.DoTransformation();
            fileWriter.WriteIntoFile("translated encrypted text.txt");

            fileWriter = new TextDecryptor(fileWriter, fileWriter.Data);
            fileWriter.DoTransformation();
            fileWriter.WriteIntoFile("translated decrypted text.txt");
        }
    }
}