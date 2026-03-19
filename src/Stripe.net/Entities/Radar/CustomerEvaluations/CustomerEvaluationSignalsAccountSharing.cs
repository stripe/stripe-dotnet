// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerEvaluationSignalsAccountSharing : StripeEntity<CustomerEvaluationSignalsAccountSharing>
    {
        /// <summary>
        /// Time at which the signal was evaluated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("evaluated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The risk level for this signal.
        /// </summary>
        [JsonProperty("risk_level")]
        [STJS.JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// Score for this signal (float between 0.0-100.0).
        /// </summary>
        [JsonProperty("score")]
        [STJS.JsonPropertyName("score")]
        public decimal Score { get; set; }
    }
}
