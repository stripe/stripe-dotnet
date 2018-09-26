namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceSofortCreateOptions : INestedOptions
    {
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
