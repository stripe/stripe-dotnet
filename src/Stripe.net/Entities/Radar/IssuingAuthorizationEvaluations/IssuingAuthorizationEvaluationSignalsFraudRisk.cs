// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IssuingAuthorizationEvaluationSignalsFraudRisk : StripeEntity<IssuingAuthorizationEvaluationSignalsFraudRisk>
    {
        /// <summary>
        /// Signal evaluation data, including score and level.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif
        public IssuingAuthorizationEvaluationSignalsFraudRiskData Data { get; set; }

        /// <summary>
        /// Details of an error that prevented reporting this signal.
        /// </summary>
        [JsonProperty("error")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error")]
#endif
        public Dictionary<string, string> Error { get; set; }

        /// <summary>
        /// The status of this signal.
        /// One of: <c>error</c>, or <c>success</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
