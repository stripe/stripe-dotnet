using Newtonsoft.Json;

namespace Stripe
{
    public class StripeRefundListOptions : StripeListOptions
    {
        [JsonProperty("charge")]
        public string ChargeId { get; set; }
    }
}