// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalsDelinquency : StripeEntity<AccountSignalsDelinquency>
    {
        /// <summary>
        /// Time at which the signal was evaluated, measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("evaluated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? EvaluatedAt { get; set; }

        /// <summary>
        /// Array of objects representing individual factors that contributed to the calculated
        /// probability of delinquency.
        /// </summary>
        [JsonProperty("indicators")]
        [STJS.JsonPropertyName("indicators")]
        public List<AccountSignalsDelinquencyIndicator> Indicators { get; set; }

        /// <summary>
        /// The probability of delinquency. Can be between 0.00 and 100.00.
        /// </summary>
        [JsonProperty("probability")]
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
