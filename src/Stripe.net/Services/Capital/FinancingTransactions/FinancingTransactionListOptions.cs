// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancingTransactionListOptions : ListOptions
    {
        /// <summary>
        /// For transactions of type <c>paydown</c> and reason <c>automatic_withholding</c> only,
        /// only returns transactions that were created as a result of this charge.
        /// </summary>
        [JsonProperty("charge")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
#endif
        public string Charge { get; set; }

        /// <summary>
        /// Returns transactions that were created that apply to this financing offer ID.
        /// </summary>
        [JsonProperty("financing_offer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financing_offer")]
#endif
        public string FinancingOffer { get; set; }

        /// <summary>
        /// Only returns transactions that are responsible for reversing this financing transaction
        /// ID.
        /// </summary>
        [JsonProperty("reversed_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reversed_transaction")]
#endif
        public string ReversedTransaction { get; set; }

        /// <summary>
        /// For transactions of type <c>paydown</c> and reason <c>automatic_withholding</c> only,
        /// only returns transactions that were created as a result of this Treasury Transaction.
        /// </summary>
        [JsonProperty("treasury_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("treasury_transaction")]
#endif
        public string TreasuryTransaction { get; set; }
    }
}
