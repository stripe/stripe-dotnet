// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentAmountDetails : StripeEntity<IntentAmountDetails>
    {
        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Amount of discount applied.
        /// </summary>
        [JsonProperty("discount")]
        [STJS.JsonPropertyName("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// Amount of shipping charges.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public string Shipping { get; set; }

        /// <summary>
        /// Subtotal amount before tax and discounts.
        /// </summary>
        [JsonProperty("subtotal")]
        [STJS.JsonPropertyName("subtotal")]
        public string Subtotal { get; set; }

        /// <summary>
        /// Amount of tax.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public string Tax { get; set; }

        /// <summary>
        /// Total amount for the Billing Intent.
        /// </summary>
        [JsonProperty("total")]
        [STJS.JsonPropertyName("total")]
        public string Total { get; set; }
    }
}
