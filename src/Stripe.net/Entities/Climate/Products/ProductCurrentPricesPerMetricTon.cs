// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductCurrentPricesPerMetricTon : StripeEntity<ProductCurrentPricesPerMetricTon>
    {
        /// <summary>
        /// Fees for one metric ton of carbon removal in the currency's smallest unit.
        /// </summary>
        [JsonProperty("amount_fees")]
        [STJS.JsonPropertyName("amount_fees")]
        public long AmountFees { get; set; }

        /// <summary>
        /// Subtotal for one metric ton of carbon removal (excluding fees) in the currency's
        /// smallest unit.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        [STJS.JsonPropertyName("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total for one metric ton of carbon removal (including fees) in the currency's smallest
        /// unit.
        /// </summary>
        [JsonProperty("amount_total")]
        [STJS.JsonPropertyName("amount_total")]
        public long AmountTotal { get; set; }
    }
}
