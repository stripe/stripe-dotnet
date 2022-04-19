// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentAmountDetailsTip : StripeEntity<PaymentIntentAmountDetailsTip>
    {
        /// <summary>
        /// Portion of the amount that corresponds to a tip.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }
    }
}
