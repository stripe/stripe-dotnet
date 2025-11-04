// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Capital
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancingOfferCreateOptions : BaseOptions
    {
        [JsonProperty("advance_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("advance_amount")]
#endif
        public long? AdvanceAmount { get; set; }

        [JsonProperty("fee_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fee_amount")]
#endif
        public long? FeeAmount { get; set; }

        /// <summary>
        /// One of: <c>cash_advance</c>, <c>fixed_term_loan</c>, or <c>flex_loan</c>.
        /// </summary>
        [JsonProperty("financing_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financing_type")]
#endif
        public string FinancingType { get; set; }

        /// <summary>
        /// One of: <c>accepted</c>, <c>accepted_other_offer</c>, <c>canceled</c>, <c>completed</c>,
        /// <c>delivered</c>, <c>expired</c>, <c>fully_repaid</c>, <c>paid_out</c>, <c>rejected</c>,
        /// <c>replaced</c>, or <c>undelivered</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        [JsonProperty("withhold_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("withhold_rate")]
#endif
        public decimal? WithholdRate { get; set; }
    }
}
