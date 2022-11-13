using Newtonsoft.Json;

namespace CommandApi.Models
{
    [JsonObject]
    public class AlexaRequest
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("request")]
        public RequestAttributes Request { get; set; }

        [JsonProperty("attributes")]
        public SessionCustomAttributes SessionCustomAttributes { get; set; }

        [JsonProperty("session")]
        public SessionAttributes Session { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("intent")]
        public IntentAttributes IntentAttributes { get; set; }
    }
}
