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
            BaseWriter writer = new FileWriter(text);
            writer.DoTransformation();
            writer.WriteIntoFile("just text.txt");

            writer = new TextTranslator(writer, writer.Data);
            writer.DoTransformation();
            writer.WriteIntoFile("translated text.txt");

            writer = new TextEncryptor(writer, writer.Data);
            writer.DoTransformation();
            writer.WriteIntoFile("translated encrypted text.txt");

            writer = new TextDecryptor(writer, writer.Data);
            writer.DoTransformation();
            writer.WriteIntoFile("translated decrypted text.txt");
        }
    }
}