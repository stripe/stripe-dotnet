// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IssuingAuthorizationEvaluationCardDetails : StripeEntity<IssuingAuthorizationEvaluationCardDetails>
    {
        /// <summary>
        /// The Bank Identification Number (BIN) of the card.
        /// </summary>
        [JsonProperty("bin")]
        [STJS.JsonPropertyName("bin")]
        public string Bin { get; set; }

        /// <summary>
        /// The two-letter country code of the BIN issuer.
        /// </summary>
        [JsonProperty("bin_country")]
        [STJS.JsonPropertyName("bin_country")]
        public string BinCountry { get; set; }

        /// <summary>
        /// The type of the card.
        /// One of: <c>physical</c>, or <c>virtual</c>.
        /// </summary>
        [JsonProperty("card_type")]
        [STJS.JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// The timestamp when the card was created, as a Unix timestamp in seconds.
        /// </summary>
        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime CreatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The last 4 digits of the card number.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// User's specified unique ID of the card for this authorization attempt (e.g., RRN or
        /// internal reference).
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
