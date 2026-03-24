// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationInsights : StripeEntity<PaymentEvaluationInsights>
    {
        /// <summary>
        /// The timestamp when the evaluation was performed.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("evaluated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Scores, insights and recommended action for one scorer for this PaymentEvaluation.
        /// </summary>
        [JsonProperty("fraudulent_dispute")]
        [STJS.JsonPropertyName("fraudulent_dispute")]
        public PaymentEvaluationInsightsFraudulentDispute FraudulentDispute { get; set; }
    }
}
