// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Capital
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancingOfferCreateOptions : BaseOptions
    {
        /// <summary>
        /// Amount of financing offered, in minor units. For example, 1,000 USD is represented as
        /// 100000.
        /// </summary>
        [JsonProperty("advance_amount")]
        [STJS.JsonPropertyName("advance_amount")]
        public long? AdvanceAmount { get; set; }

        /// <summary>
        /// Fixed fee amount, in minor units. For example, 100 USD is represented as 10000.
        /// </summary>
        [JsonProperty("fee_amount")]
        [STJS.JsonPropertyName("fee_amount")]
        public long? FeeAmount { get; set; }

        /// <summary>
        /// The type of financing offer.
        /// One of: <c>cash_advance</c>, <c>fixed_term_loan</c>, or <c>flex_loan</c>.
        /// </summary>
        [JsonProperty("financing_type")]
        [STJS.JsonPropertyName("financing_type")]
        public string FinancingType { get; set; }

        /// <summary>
        /// The status of the financing offer.
        /// One of: <c>accepted</c>, <c>accepted_other_offer</c>, <c>canceled</c>, <c>completed</c>,
        /// <c>delivered</c>, <c>expired</c>, <c>fully_repaid</c>, <c>paid_out</c>, <c>rejected</c>,
        /// <c>replaced</c>, or <c>undelivered</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Per-transaction rate at which Stripe withholds funds to repay the financing.
        /// </summary>
        [JsonProperty("withhold_rate")]
        [STJS.JsonPropertyName("withhold_rate")]
        public decimal? WithholdRate { get; set; }
    }
}
