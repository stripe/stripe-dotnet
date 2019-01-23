namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceMultibanco : StripeEntity<SourceMultibanco>
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("Reference")]
        public string Reference { get; set; }
    }
}
