namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceP24 : StripeEntity<SourceP24>
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
