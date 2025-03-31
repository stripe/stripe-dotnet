// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Returns objects associated with this FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// The results are in reverse chronological order by <c>created</c> or <c>posted_at</c>.
        /// The default is <c>created</c>.
        /// One of: <c>created</c>, or <c>posted_at</c>.
        /// </summary>
        [JsonProperty("order_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("order_by")]
#endif
        public string OrderBy { get; set; }

        /// <summary>
        /// Only return Transactions that have the given status: <c>open</c>, <c>posted</c>, or
        /// <c>void</c>.
        /// One of: <c>open</c>, <c>posted</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// A filter for the <c>status_transitions.posted_at</c> timestamp. When using this filter,
        /// <c>status=posted</c> and <c>order_by=posted_at</c> must also be specified.
        /// </summary>
        [JsonProperty("status_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_transitions")]
#endif
        public TransactionStatusTransitionsOptions StatusTransitions { get; set; }
    }
}
