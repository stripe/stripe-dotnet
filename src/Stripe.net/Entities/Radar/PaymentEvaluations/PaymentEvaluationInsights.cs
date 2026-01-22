// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationInsights : StripeEntity<PaymentEvaluationInsights>
    {
        /// <summary>
        /// Stripe Radar's evaluation of the likelihood of a card issuer decline on this payment.
        /// </summary>
        [JsonProperty("card_issuer_decline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_issuer_decline")]
#endif
        public PaymentEvaluationInsightsCardIssuerDecline CardIssuerDecline { get; set; }

        /// <summary>
        /// The timestamp when the evaluation was performed.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("evaluated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Scores, insights and recommended action for one scorer for this PaymentEvaluation.
        /// </summary>
        [JsonProperty("fraudulent_dispute")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fraudulent_dispute")]
#endif
        public PaymentEvaluationInsightsFraudulentDispute FraudulentDispute { get; set; }
    }
}
