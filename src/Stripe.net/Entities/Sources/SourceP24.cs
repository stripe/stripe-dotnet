namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceP24 : StripeEntity
    {
        [JsonProperty("Reference")]
        public string Reference { get; set; }
    }
}
