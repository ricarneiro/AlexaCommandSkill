using Newtonsoft.Json;

namespace CommandApi.Models
{
    public class UserAttributes
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
    }
}
