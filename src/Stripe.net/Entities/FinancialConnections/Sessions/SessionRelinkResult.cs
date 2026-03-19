// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionRelinkResult : StripeEntity<SessionRelinkResult>
    {
        /// <summary>
        /// The account relinked in the Session. Only present if <c>relink_options[account]</c> is
        /// set and relink is successful.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The authorization relinked in the Session. Only present if relink is successful.
        /// </summary>
        [JsonProperty("authorization")]
        [STJS.JsonPropertyName("authorization")]
        public string Authorization { get; set; }

        /// <summary>
        /// Reason for why relink failed. One of <c>no_authorization</c>, <c>no_account</c>, or
        /// <c>other</c>.
        /// One of: <c>no_account</c>, <c>no_authorization</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("failure_reason")]
        [STJS.JsonPropertyName("failure_reason")]
        public string FailureReason { get; set; }
    }
}
