// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ProductCurrentPricesPerMetricTon : StripeEntity<ProductCurrentPricesPerMetricTon>
    {
        /// <summary>
        /// Fees for one metric ton of carbon removal in the currency's smallest unit.
        /// </summary>
        [JsonProperty("amount_fees")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_fees")]
#endif
        public long AmountFees { get; set; }

        /// <summary>
        /// Subtotal for one metric ton of carbon removal (excluding fees) in the currency's
        /// smallest unit.
        /// </summary>
        [JsonProperty("amount_subtotal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_subtotal")]
#endif
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total for one metric ton of carbon removal (including fees) in the currency's smallest
        /// unit.
        /// </summary>
        [JsonProperty("amount_total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_total")]
#endif
        public long AmountTotal { get; set; }
    }
}
