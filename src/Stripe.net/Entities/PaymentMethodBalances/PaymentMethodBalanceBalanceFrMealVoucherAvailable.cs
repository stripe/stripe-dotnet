// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodBalanceBalanceFrMealVoucherAvailable : StripeEntity<PaymentMethodBalanceBalanceFrMealVoucherAvailable>
    {
        /// <summary>
        /// The amount of the balance.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The currency of the balance.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
