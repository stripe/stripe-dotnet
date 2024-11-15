// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditReversalListOptions : ListOptions
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
        /// Only return CreditReversals for the ReceivedCredit ID.
        /// </summary>
        [JsonProperty("received_credit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_credit")]
#endif

        public string ReceivedCredit { get; set; }

        /// <summary>
        /// Only return CreditReversals for a given status.
        /// One of: <c>canceled</c>, <c>posted</c>, or <c>processing</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }
    }
}
