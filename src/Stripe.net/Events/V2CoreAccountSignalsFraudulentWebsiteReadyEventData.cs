// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V2CoreAccountSignalsFraudulentWebsiteReadyEventData : StripeEntity<V2CoreAccountSignalsFraudulentWebsiteReadyEventData>
    {
        /// <summary>
        /// The account for which the signals belong to. Empty if this was an entityless request.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Human readable description of concerns found in the website, produced by LLM. If
        /// risk_level is unknown, this explains why evaluation could not run.
        /// </summary>
        [JsonProperty("details")]
        [STJS.JsonPropertyName("details")]
        public string Details { get; set; }

        /// <summary>
        /// Time at which the signal was evaluated.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [STJS.JsonPropertyName("evaluated_at")]
        public DateTime EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Unique identifier for the fraudulent website evaluation request.
        /// </summary>
        [JsonProperty("evaluation_id")]
        [STJS.JsonPropertyName("evaluation_id")]
        public string EvaluationId { get; set; }

        /// <summary>
        /// Risk level for the fraudulent website signal. If evaluation could not run (like invalid
        /// website), we return unknown.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, <c>not_assessed</c>,
        /// or <c>unknown</c>.
        /// </summary>
        [JsonProperty("risk_level")]
        [STJS.JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// Unique identifier for the fraudulent website signal.
        /// </summary>
        [JsonProperty("signal_id")]
        [STJS.JsonPropertyName("signal_id")]
        public string SignalId { get; set; }
    }
}
