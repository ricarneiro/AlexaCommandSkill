using Newtonsoft.Json;

namespace CommandApi.Models
{
    public class ResponseAttributes
    {
        [JsonProperty("shouldEndSession")]
        public bool ShouldEndSession { get; set; }

        [JsonProperty("outputSpeech")]
        public OutputSpeechAttributes OutputSpeech { get; set; }

        [JsonProperty("card")]
        public CardAttributes Card { get; set; }

        [JsonProperty("reprompt")]
        public RepromptAttributes Reprompt { get; set; }

        public ResponseAttributes()
        {
            ShouldEndSession = true;
            OutputSpeech = new OutputSpeechAttributes();
            Card = new CardAttributes();
            Reprompt = new RepromptAttributes();
        }
    }
}
