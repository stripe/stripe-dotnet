// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IssuingAuthorizationEvaluationSignalsFraudRisk : StripeEntity<IssuingAuthorizationEvaluationSignalsFraudRisk>
    {
        /// <summary>
        /// Signal evaluation data, including score and level.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public IssuingAuthorizationEvaluationSignalsFraudRiskData Data { get; set; }

        /// <summary>
        /// Details of an error that prevented reporting this signal.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public Dictionary<string, string> Error { get; set; }

        /// <summary>
        /// The status of this signal.
        /// One of: <c>error</c>, or <c>success</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
