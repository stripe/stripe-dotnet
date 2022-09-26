// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;

    public class FinancingOfferAcceptedTerms : StripeEntity<FinancingOfferAcceptedTerms>
    {
        /// <summary>
        /// Amount of financing offered, in minor units.
        /// </summary>
        [JsonProperty("advance_amount")]
        public long AdvanceAmount { get; set; }

        /// <summary>
        /// Currency that the financing offer is transacted in. For example, <c>usd</c>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Fixed fee amount, in minor units.
        /// </summary>
        [JsonProperty("fee_amount")]
        public long FeeAmount { get; set; }

        /// <summary>
        /// Populated when the <c>product_type</c> of the <c>financingoffer</c> is <c>refill</c>.
        /// Represents the discount amount on remaining premium for the existing loan at payout
        /// time.
        /// </summary>
        [JsonProperty("previous_financing_fee_discount_amount")]
        public long? PreviousFinancingFeeDiscountAmount { get; set; }

        /// <summary>
        /// Per-transaction rate at which Stripe will withhold funds to repay the financing.
        /// </summary>
        [JsonProperty("withhold_rate")]
        public decimal WithholdRate { get; set; }
    }
}
