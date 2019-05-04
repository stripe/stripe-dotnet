namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceP24 : StripeEntity
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
