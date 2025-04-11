// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancingOfferAcceptedTerms : StripeEntity<FinancingOfferAcceptedTerms>
    {
        /// <summary>
        /// Amount of financing offered, in minor units. For example, $1,000 USD will be represented
        /// as 100000.
        /// </summary>
        [JsonProperty("advance_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("advance_amount")]
#endif
        public long AdvanceAmount { get; set; }

        /// <summary>
        /// Currency that the financing offer is transacted in. For example, <c>usd</c>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Fixed fee amount, in minor units. For example, $100 USD will be represented as 10000.
        /// </summary>
        [JsonProperty("fee_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fee_amount")]
#endif
        public long FeeAmount { get; set; }

        /// <summary>
        /// Populated when the <c>product_type</c> of the <c>financingoffer</c> is <c>refill</c>.
        /// Represents the discount amount on remaining premium for the existing loan at payout
        /// time.
        /// </summary>
        [JsonProperty("previous_financing_fee_discount_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("previous_financing_fee_discount_amount")]
#endif
        public long? PreviousFinancingFeeDiscountAmount { get; set; }

        /// <summary>
        /// Per-transaction rate at which Stripe will withhold funds to repay the financing.
        /// </summary>
        [JsonProperty("withhold_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("withhold_rate")]
#endif
        public decimal WithholdRate { get; set; }
    }
}
