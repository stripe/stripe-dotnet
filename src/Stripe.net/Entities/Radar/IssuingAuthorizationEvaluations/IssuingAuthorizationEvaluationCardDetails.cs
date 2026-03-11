// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IssuingAuthorizationEvaluationCardDetails : StripeEntity<IssuingAuthorizationEvaluationCardDetails>
    {
        /// <summary>
        /// The Bank Identification Number (BIN) of the card.
        /// </summary>
        [JsonProperty("bin")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bin")]
#endif
        public string Bin { get; set; }

        /// <summary>
        /// The country code associated with the card BIN.
        /// </summary>
        [JsonProperty("bin_country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bin_country")]
#endif
        public string BinCountry { get; set; }

        /// <summary>
        /// The type of card (physical or virtual).
        /// One of: <c>physical</c>, or <c>virtual</c>.
        /// </summary>
        [JsonProperty("card_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_type")]
#endif
        public string CardType { get; set; }

        /// <summary>
        /// The time when the card was created.
        /// </summary>
        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime CreatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The last 4 digits of the card number.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// External reference for the card.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }
    }
}
