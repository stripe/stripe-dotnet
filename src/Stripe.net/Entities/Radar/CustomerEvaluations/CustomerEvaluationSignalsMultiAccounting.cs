// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerEvaluationSignalsMultiAccounting : StripeEntity<CustomerEvaluationSignalsMultiAccounting>
    {
        /// <summary>
        /// Time at which the signal was evaluated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("evaluated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The risk level for this signal.
        /// </summary>
        [JsonProperty("risk_level")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("risk_level")]
#endif
        public string RiskLevel { get; set; }

        /// <summary>
        /// Score for this signal (float between 0.0-100.0).
        /// </summary>
        [JsonProperty("score")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("score")]
#endif
        public decimal Score { get; set; }
    }
}
