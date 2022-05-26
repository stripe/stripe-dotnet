// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentAmountDetails : StripeEntity<PaymentIntentAmountDetails>
    {
        [JsonProperty("tip")]
        public PaymentIntentAmountDetailsTip Tip { get; set; }
    }
}
