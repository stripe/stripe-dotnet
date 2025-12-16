// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsLodgingDatumAccommodationOptions : INestedOptions
    {
        /// <summary>
        /// Type of accommodation.
        /// One of: <c>apartment</c>, <c>cabana</c>, <c>house</c>, <c>penthouse</c>, <c>room</c>,
        /// <c>standard</c>, <c>suite</c>, or <c>villa</c>.
        /// </summary>
        [JsonProperty("accommodation_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("accommodation_type")]
#endif
        public string AccommodationType { get; set; }

        /// <summary>
        /// Bed type.
        /// </summary>
        [JsonProperty("bed_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bed_type")]
#endif
        public string BedType { get; set; }

        /// <summary>
        /// Daily accommodation rate in cents.
        /// </summary>
        [JsonProperty("daily_rate_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("daily_rate_amount")]
#endif
        public long? DailyRateAmount { get; set; }

        /// <summary>
        /// Number of nights.
        /// </summary>
        [JsonProperty("nights")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nights")]
#endif
        public long? Nights { get; set; }

        /// <summary>
        /// Number of rooms, cabanas, apartments, and so on.
        /// </summary>
        [JsonProperty("number_of_rooms")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number_of_rooms")]
#endif
        public long? NumberOfRooms { get; set; }

        /// <summary>
        /// Rate type.
        /// </summary>
        [JsonProperty("rate_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_type")]
#endif
        public string RateType { get; set; }

        /// <summary>
        /// Whether smoking is allowed.
        /// </summary>
        [JsonProperty("smoking_indicator")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("smoking_indicator")]
#endif
        public bool? SmokingIndicator { get; set; }
    }
}
