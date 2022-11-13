using Newtonsoft.Json;

namespace CommandApi.Models
{
    public class SessionCustomAttributes
    {
        [JsonProperty("memberId")]
        public int MemberId { get; set; }

        [JsonProperty("lastIntentName")]
        public string LastIntentName { get; set; }
    }

}
