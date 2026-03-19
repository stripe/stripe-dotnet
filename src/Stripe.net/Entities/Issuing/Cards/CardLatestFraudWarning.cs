// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardLatestFraudWarning : StripeEntity<CardLatestFraudWarning>
    {
        /// <summary>
        /// Timestamp of the most recent fraud warning.
        /// </summary>
        [JsonProperty("started_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("started_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// The type of fraud warning that most recently took place on this card. This field updates
        /// with every new fraud warning, so the value changes over time. If populated, cancel and
        /// reissue the card.
        /// One of: <c>card_testing_exposure</c>, <c>fraud_dispute_filed</c>,
        /// <c>third_party_reported</c>, or <c>user_indicated_fraud</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
