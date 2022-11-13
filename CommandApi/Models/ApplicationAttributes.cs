using Newtonsoft.Json;

namespace CommandApi.Models
{
    public class ApplicationAttributes
    {
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }
    }

}
