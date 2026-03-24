// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsFlightSegmentOptions : INestedOptions
    {
        /// <summary>
        /// The flight segment amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The International Air Transport Association (IATA) airport code for the arrival airport.
        /// </summary>
        [JsonProperty("arrival_airport")]
        [STJS.JsonPropertyName("arrival_airport")]
        public string ArrivalAirport { get; set; }

        /// <summary>
        /// The arrival time for the flight segment. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("arrives_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("arrives_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ArrivesAt { get; set; }

        /// <summary>
        /// The International Air Transport Association (IATA) carrier code of the carrier operating
        /// the flight segment.
        /// </summary>
        [JsonProperty("carrier")]
        [STJS.JsonPropertyName("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// The departure time for the flight segment. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("departs_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("departs_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? DepartsAt { get; set; }

        /// <summary>
        /// The International Air Transport Association (IATA) airport code for the departure
        /// airport.
        /// </summary>
        [JsonProperty("departure_airport")]
        [STJS.JsonPropertyName("departure_airport")]
        public string DepartureAirport { get; set; }

        /// <summary>
        /// The flight number associated with the segment.
        /// </summary>
        [JsonProperty("flight_number")]
        [STJS.JsonPropertyName("flight_number")]
        public string FlightNumber { get; set; }

        /// <summary>
        /// The fare class for the segment.
        /// One of: <c>business</c>, <c>economy</c>, <c>first</c>, or <c>premium_economy</c>.
        /// </summary>
        [JsonProperty("service_class")]
        [STJS.JsonPropertyName("service_class")]
        public string ServiceClass { get; set; }
    }
}
