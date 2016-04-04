using Newtonsoft.Json;

namespace Stripe
{
    public class StripeFraudDetails : StripeObject
    {
        [JsonProperty("stripe_report")]
        public string StripeReport { get; set; }
    }
}