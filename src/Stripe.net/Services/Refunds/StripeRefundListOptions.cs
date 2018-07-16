namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeRefundListOptions : StripeListOptions
    {
        [JsonProperty("charge")]
        public string ChargeId { get; set; }
    }
}