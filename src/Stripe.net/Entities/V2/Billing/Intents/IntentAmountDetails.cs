// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentAmountDetails : StripeEntity<IntentAmountDetails>
    {
        /// <summary>
        /// Three-letter ISO currency code, in lowercase.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Amount of discount applied.
        /// </summary>
        [JsonProperty("discount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount")]
#endif
        public string Discount { get; set; }

        /// <summary>
        /// Amount of shipping charges.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif
        public string Shipping { get; set; }

        /// <summary>
        /// Subtotal amount before tax and discounts.
        /// </summary>
        [JsonProperty("subtotal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subtotal")]
#endif
        public string Subtotal { get; set; }

        /// <summary>
        /// Amount of tax.
        /// </summary>
        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public string Tax { get; set; }

        /// <summary>
        /// Total amount for the BillingIntent.
        /// </summary>
        [JsonProperty("total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total")]
#endif
        public string Total { get; set; }
    }
}
