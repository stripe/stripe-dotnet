namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeChargeListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }
    }
}
