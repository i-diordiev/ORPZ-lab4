using Google.Apis.Auth.OAuth2;
using Google.Cloud.Translation.V2;

namespace ORPZ_lab4.Decorator
{
    public class TextTranslator : TextTransformer
    {
        private readonly string _langCode;
        public TextTranslator(BaseFileWriter fileWriter, string languageCode, string data) : base(fileWriter, data)
        {
            _langCode = languageCode;
        }

        public override void DoTransformation()
        {
            var credential = GoogleCredential.FromFile("data-rush-352606-cd1f1491d7ca.json");
            var translationClient = TranslationClient.Create(credential);
            Data = translationClient.TranslateText(Data, _langCode).TranslatedText;
        }
    }
}