using System.Collections.Generic;
using System.IO;
using System.Linq;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Translation.V2;

namespace ORPZ_lab4.Translation
{
    public class TranslationFileWriter : ITranslationFileWriter
    {
        private readonly TranslationClient _translationClient;

        public TranslationFileWriter()
        {
            var credential = GoogleCredential.FromFile("data-rush-352606-cd1f1491d7ca.json");
            _translationClient = TranslationClient.Create(credential);
        }
        
        public void Translate(string text, string languageCode, string fileName)
        {
            var words = SeparateTextIntoWords(text);
            var translatedResults = _translationClient.TranslateText(words, languageCode);
            var translatedWords = translatedResults.Select(tr => tr.TranslatedText);
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var word in translatedWords)
                {
                    writer.WriteLine(word);
                }
            }
        }

        private IEnumerable<string> SeparateTextIntoWords(string text)
        {
            return text.Split('.', ',', ' ');
        }
    }
}