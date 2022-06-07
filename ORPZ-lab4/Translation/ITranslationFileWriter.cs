namespace ORPZ_lab4.Translation
{
    public interface ITranslationFileWriter
    {
        void Translate(string text, string languageCode, string fileName);
    }
}