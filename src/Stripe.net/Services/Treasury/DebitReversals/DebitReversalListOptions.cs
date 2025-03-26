// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DebitReversalListOptions : ListOptions
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
        /// Only return DebitReversals for the ReceivedDebit ID.
        /// </summary>
        [JsonProperty("received_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_debit")]
#endif
        public string ReceivedDebit { get; set; }

        /// <summary>
        /// Only return DebitReversals for a given resolution.
        /// One of: <c>lost</c>, or <c>won</c>.
        /// </summary>
        [JsonProperty("resolution")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("resolution")]
#endif
        public string Resolution { get; set; }

        /// <summary>
        /// Only return DebitReversals for a given status.
        /// One of: <c>canceled</c>, <c>completed</c>, or <c>processing</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
