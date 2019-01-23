namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceP24 : StripeEntity<SourceP24>
    {
        [JsonProperty("Reference")]
        public string Reference { get; set; }
    }
}
