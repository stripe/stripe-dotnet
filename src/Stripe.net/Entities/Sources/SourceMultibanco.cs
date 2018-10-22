namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceMultibanco : StripeEntity
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("Reference")]
        public string Reference { get; set; }
    }
}
