using Google.Apis.Auth.OAuth2;
using Google.Cloud.Translation.V2;

namespace ORPZ_lab4.Decorator
{
    public class TextTranslator : TextTransformer
    {
        public TextTranslator(BaseWriter writer, string data) : base(writer, data)
        {
        }

        public override void DoTransformation()
        {
            var credential = GoogleCredential.FromFile("data-rush-352606-cd1f1491d7ca.json");
            var translationClient = TranslationClient.Create(credential);
            _data = translationClient.TranslateText(_data, "ru").TranslatedText;
        }
    }
}