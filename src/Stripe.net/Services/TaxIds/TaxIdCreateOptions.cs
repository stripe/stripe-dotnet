namespace Stripe
{
    using Newtonsoft.Json;

    public class TaxIdCreateOptions : BaseOptions
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
