using Newtonsoft.Json;

namespace CommandApi.Models
{
    [JsonObject("reprompt")]
    public class RepromptAttributes
    {
        [JsonProperty("outputSpeech")]
        public OutputSpeechAttributes OutputSpeech { get; set; }

        public RepromptAttributes()
        {
            OutputSpeech = new OutputSpeechAttributes();
        }
    }
}
