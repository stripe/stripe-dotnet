namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeTopupListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }
    }
}
