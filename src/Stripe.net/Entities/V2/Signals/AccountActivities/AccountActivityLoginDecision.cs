// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountActivityLoginDecision : StripeEntity<AccountActivityLoginDecision>
    {
        /// <summary>
        /// Multi-factor authentication challenges performed during the login process.
        /// </summary>
        [JsonProperty("mfa_challenges")]
        [STJS.JsonPropertyName("mfa_challenges")]
        public List<AccountActivityLoginDecisionMfaChallenge> MfaChallenges { get; set; }

        /// <summary>
        /// The action the merchant took following the evaluation.
        /// One of: <c>allowed</c>, <c>blocked</c>, or <c>restricted</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
