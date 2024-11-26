// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionPurchaseDetailsFlightSegment : StripeEntity<TransactionPurchaseDetailsFlightSegment>
    {
        /// <summary>
        /// The three-letter IATA airport code of the flight's destination.
        /// </summary>
        [JsonProperty("arrival_airport_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("arrival_airport_code")]
#endif
        public string ArrivalAirportCode { get; set; }

        /// <summary>
        /// The airline carrier code.
        /// </summary>
        [JsonProperty("carrier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("carrier")]
#endif
        public string Carrier { get; set; }

        /// <summary>
        /// The three-letter IATA airport code that the flight departed from.
        /// </summary>
        [JsonProperty("departure_airport_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("departure_airport_code")]
#endif
        public string DepartureAirportCode { get; set; }

        /// <summary>
        /// The flight number.
        /// </summary>
        [JsonProperty("flight_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flight_number")]
#endif
        public string FlightNumber { get; set; }

        /// <summary>
        /// The flight's service class.
        /// </summary>
        [JsonProperty("service_class")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_class")]
#endif
        public string ServiceClass { get; set; }

        /// <summary>
        /// Whether a stopover is allowed on this flight.
        /// </summary>
        [JsonProperty("stopover_allowed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stopover_allowed")]
#endif
        public bool? StopoverAllowed { get; set; }
    }
}
