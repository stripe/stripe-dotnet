// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BillingEvaluationSignalsNonPaymentAbuse : StripeEntity<BillingEvaluationSignalsNonPaymentAbuse>
    {
        /// <summary>
        /// The time when this signal was evaluated.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("evaluated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Risk level.
        /// One of: <c>elevated</c>, <c>highest</c>, <c>low</c>, <c>normal</c>, <c>not_assessed</c>,
        /// or <c>unknown</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("risk_level")]
        [STJS.JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }
    }
}
