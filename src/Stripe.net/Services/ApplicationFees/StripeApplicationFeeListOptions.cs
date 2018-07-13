namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeApplicationFeeListOptions : StripeListOptions
    {
        [JsonProperty("charge")]
        public string ChargeId { get; set; }

        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }
    }
}