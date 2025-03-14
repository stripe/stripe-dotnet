// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsFlightSegmentOptions : INestedOptions
    {
        /// <summary>
        /// The flight segment amount.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// The International Air Transport Association (IATA) airport code for the arrival airport.
        /// </summary>
        [JsonProperty("arrival_airport")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("arrival_airport")]
#endif
        public string ArrivalAirport { get; set; }

        /// <summary>
        /// The arrival time for the flight segment. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("arrives_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("arrives_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ArrivesAt { get; set; }

        /// <summary>
        /// The International Air Transport Association (IATA) carrier code of the carrier operating
        /// the flight segment.
        /// </summary>
        [JsonProperty("carrier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("carrier")]
#endif
        public string Carrier { get; set; }

        /// <summary>
        /// The departure time for the flight segment. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("departs_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("departs_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? DepartsAt { get; set; }

        /// <summary>
        /// The International Air Transport Association (IATA) airport code for the departure
        /// airport.
        /// </summary>
        [JsonProperty("departure_airport")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("departure_airport")]
#endif
        public string DepartureAirport { get; set; }

        /// <summary>
        /// The flight number associated with the segment.
        /// </summary>
        [JsonProperty("flight_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flight_number")]
#endif
        public string FlightNumber { get; set; }

        /// <summary>
        /// The fare class for the segment.
        /// One of: <c>business</c>, <c>economy</c>, <c>first</c>, or <c>premium_economy</c>.
        /// </summary>
        [JsonProperty("service_class")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_class")]
#endif
        public string ServiceClass { get; set; }
    }
}
