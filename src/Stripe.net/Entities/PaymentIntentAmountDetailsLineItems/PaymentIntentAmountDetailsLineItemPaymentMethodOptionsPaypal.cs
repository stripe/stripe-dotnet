// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsPaypal : StripeEntity<PaymentIntentAmountDetailsLineItemPaymentMethodOptionsPaypal>
    {
        /// <summary>
        /// Type of the line item.
        /// One of: <c>digital_goods</c>, <c>donation</c>, or <c>physical_goods</c>.
        /// </summary>
        [JsonProperty("category")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("category")]
#endif
        public string Category { get; set; }

        /// <summary>
        /// Description of the line item.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The Stripe account ID of the connected account that sells the item. This is only needed
        /// when using <a
        /// href="https://docs.stripe.com/connect/separate-charges-and-transfers">Separate Charges
        /// and Transfers</a>.
        /// </summary>
        [JsonProperty("sold_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sold_by")]
#endif
        public string SoldBy { get; set; }
    }
}
