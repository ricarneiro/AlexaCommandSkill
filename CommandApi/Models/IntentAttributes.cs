using Newtonsoft.Json;

namespace CommandApi.Models
{
    public class IntentAttributes
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slots")]
        public dynamic Slots { get; set; }

        public List<KeyValuePair<string, string>> GetSlots()
        {
            var output = new List<KeyValuePair<string, string>>();
            if (Slots == null) return output;

            foreach (var slot in Slots.Children())
            {
                if (slot.First.value != null)
                    output.Add(new KeyValuePair<string, string>(slot.First.name.ToString(), slot.First.value.ToString()));
            }

            return output;
        }
    }
}
