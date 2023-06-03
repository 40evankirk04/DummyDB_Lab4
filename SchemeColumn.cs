using Newtonsoft.Json;

namespace DummyDB
{
    public class SchemeColumn
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
