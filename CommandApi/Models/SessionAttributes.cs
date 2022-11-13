using Newtonsoft.Json;
using static CommandApi.Models.AlexaRequest;

namespace CommandApi.Models
{
    public class SessionAttributes
    {
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("application")]
        public ApplicationAttributes Application { get; set; }

        [JsonProperty("attributes")]
        public SessionCustomAttributes Attributes { get; set; }

        [JsonProperty("user")]
        public UserAttributes User { get; set; }

        [JsonProperty("new")]
        public bool New { get; set; }

        [JsonProperty("application")]
        public ApplicationAttributes ApplicationAttributes { get; set; }

        [JsonProperty("user")]
        public UserAttributes UserAttributes { get; set; }
    }

}
