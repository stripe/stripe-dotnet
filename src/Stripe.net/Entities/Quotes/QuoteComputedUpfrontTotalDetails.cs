// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteComputedUpfrontTotalDetails : StripeEntity<QuoteComputedUpfrontTotalDetails>
    {
        /// <summary>
        /// This is the sum of all the discounts.
        /// </summary>
        [JsonProperty("amount_discount")]
        [STJS.JsonPropertyName("amount_discount")]
        public long AmountDiscount { get; set; }

        /// <summary>
        /// This is the sum of all the shipping amounts.
        /// </summary>
        [JsonProperty("amount_shipping")]
        [STJS.JsonPropertyName("amount_shipping")]
        public long? AmountShipping { get; set; }

        /// <summary>
        /// This is the sum of all the tax amounts.
        /// </summary>
        [JsonProperty("amount_tax")]
        [STJS.JsonPropertyName("amount_tax")]
        public long AmountTax { get; set; }

        [JsonProperty("breakdown")]
        [STJS.JsonPropertyName("breakdown")]
        public QuoteComputedUpfrontTotalDetailsBreakdown Breakdown { get; set; }
    }
}
