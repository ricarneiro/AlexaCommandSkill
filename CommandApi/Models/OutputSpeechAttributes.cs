using Newtonsoft.Json;

namespace CommandApi.Models
{
    [JsonObject("outputSpeech")]
    public class OutputSpeechAttributes
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("ssml")]
        public string Ssml { get; set; }

        public OutputSpeechAttributes()
        {
            Type = "PlainText";
        }
    }
}
