// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderTotalDetails : StripeEntity<OrderTotalDetails>
    {
        [JsonProperty("amount_credit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_credit")]
#endif
        public long AmountCredit { get; set; }

        /// <summary>
        /// This is the sum of all the discounts.
        /// </summary>
        [JsonProperty("amount_discount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_discount")]
#endif
        public long AmountDiscount { get; set; }

        /// <summary>
        /// This is the sum of all the shipping amounts.
        /// </summary>
        [JsonProperty("amount_shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_shipping")]
#endif
        public long? AmountShipping { get; set; }

        /// <summary>
        /// This is the sum of all the tax amounts.
        /// </summary>
        [JsonProperty("amount_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_tax")]
#endif
        public long AmountTax { get; set; }

        [JsonProperty("breakdown")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("breakdown")]
#endif
        public OrderTotalDetailsBreakdown Breakdown { get; set; }
    }
}
