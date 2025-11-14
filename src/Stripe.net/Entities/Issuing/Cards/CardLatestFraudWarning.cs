// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardLatestFraudWarning : StripeEntity<CardLatestFraudWarning>
    {
        /// <summary>
        /// Timestamp of the most recent fraud warning.
        /// </summary>
        [JsonProperty("started_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("started_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// The type of fraud warning that most recently took place on this card. This field updates
        /// with every new fraud warning, so the value changes over time. If populated, cancel and
        /// reissue the card.
        /// One of: <c>card_testing_exposure</c>, <c>fraud_dispute_filed</c>,
        /// <c>third_party_reported</c>, or <c>user_indicated_fraud</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
