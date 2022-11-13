using Newtonsoft.Json;

namespace CommandApi.Models
{
    [JsonObject("card")]
    public class CardAttributes
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        public CardAttributes()
        {
            Type = "Simple";
        }
    }
}
