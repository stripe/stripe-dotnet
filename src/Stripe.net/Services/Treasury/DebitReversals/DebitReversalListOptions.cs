// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DebitReversalListOptions : ListOptions
    {
        /// <summary>
        /// Returns objects associated with this FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Only return DebitReversals for the ReceivedDebit ID.
        /// </summary>
        [JsonProperty("received_debit")]
        [STJS.JsonPropertyName("received_debit")]
        public string ReceivedDebit { get; set; }

        /// <summary>
        /// Only return DebitReversals for a given resolution.
        /// One of: <c>lost</c>, or <c>won</c>.
        /// </summary>
        [JsonProperty("resolution")]
        [STJS.JsonPropertyName("resolution")]
        public string Resolution { get; set; }

        /// <summary>
        /// Only return DebitReversals for a given status.
        /// One of: <c>canceled</c>, <c>completed</c>, or <c>processing</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
