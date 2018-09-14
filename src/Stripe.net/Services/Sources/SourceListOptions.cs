namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceListOptions : ListOptions
    {
        [JsonProperty("object")]
        internal string Object => "source";

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
