// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsLodgingDatumAccommodation : StripeEntity<PaymentIntentPaymentDetailsLodgingDatumAccommodation>
    {
        /// <summary>
        /// Type of accommodation.
        /// One of: <c>apartment</c>, <c>cabana</c>, <c>house</c>, <c>penthouse</c>, <c>room</c>,
        /// <c>standard</c>, <c>suite</c>, or <c>villa</c>.
        /// </summary>
        [JsonProperty("accommodation_type")]
        [STJS.JsonPropertyName("accommodation_type")]
        public string AccommodationType { get; set; }

        /// <summary>
        /// Bed type.
        /// </summary>
        [JsonProperty("bed_type")]
        [STJS.JsonPropertyName("bed_type")]
        public string BedType { get; set; }

        /// <summary>
        /// Daily accommodation rate in cents.
        /// </summary>
        [JsonProperty("daily_rate_amount")]
        [STJS.JsonPropertyName("daily_rate_amount")]
        public long DailyRateAmount { get; set; }

        /// <summary>
        /// Number of nights.
        /// </summary>
        [JsonProperty("nights")]
        [STJS.JsonPropertyName("nights")]
        public long Nights { get; set; }

        /// <summary>
        /// Number of rooms, cabanas, apartments, and so on.
        /// </summary>
        [JsonProperty("number_of_rooms")]
        [STJS.JsonPropertyName("number_of_rooms")]
        public long NumberOfRooms { get; set; }

        /// <summary>
        /// Rate type.
        /// </summary>
        [JsonProperty("rate_type")]
        [STJS.JsonPropertyName("rate_type")]
        public string RateType { get; set; }

        /// <summary>
        /// Whether smoking is allowed.
        /// </summary>
        [JsonProperty("smoking_indicator")]
        [STJS.JsonPropertyName("smoking_indicator")]
        public bool SmokingIndicator { get; set; }
    }
}
