// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionRelinkResult : StripeEntity<SessionRelinkResult>
    {
        /// <summary>
        /// The account relinked in the Session. Only present if <c>relink_options[account]</c> is
        /// set and relink is successful.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The authorization relinked in the Session. Only present if relink is successful.
        /// </summary>
        [JsonProperty("authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization")]
#endif
        public string Authorization { get; set; }

        /// <summary>
        /// Reason for why relink failed. One of <c>no_authorization</c>, <c>no_account</c>, or
        /// <c>other</c>.
        /// One of: <c>no_account</c>, <c>no_authorization</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("failure_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_reason")]
#endif
        public string FailureReason { get; set; }
    }
}
