// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V1AccountSignalsIncludingDelinquencyCreatedEventData : StripeEntity<V1AccountSignalsIncludingDelinquencyCreatedEventData>
    {
        /// <summary>
        /// The account for which the signals belong to.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Time at which the signal was evaluated.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [STJS.JsonPropertyName("evaluated_at")]
        public DateTime EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Array of objects representing individual factors that contributed to the calculated
        /// probability of delinquency.
        /// </summary>
        [JsonProperty("indicators")]
        [STJS.JsonPropertyName("indicators")]
        public List<V1AccountSignalsIncludingDelinquencyCreatedEventDataIndicator> Indicators { get; set; }

        /// <summary>
        /// The probability of delinquency. Can be between 0.00 and 100.00.
        /// </summary>
        [JsonProperty("probability")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("probability")]
        public decimal? Probability { get; set; }

        /// <summary>
        /// Categorical assessment of the delinquency risk based on probability.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, <c>not_assessed</c>,
        /// or <c>unknown</c>.
        /// </summary>
        [JsonProperty("risk_level")]
        [STJS.JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// Unique identifier for the delinquency signal.
        /// </summary>
        [JsonProperty("signal_id")]
        [STJS.JsonPropertyName("signal_id")]
        public string SignalId { get; set; }
    }
}
