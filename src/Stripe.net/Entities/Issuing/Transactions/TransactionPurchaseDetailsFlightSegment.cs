namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TransactionPurchaseDetailsFlightSegment : StripeEntity<TransactionPurchaseDetailsFlightSegment>
    {
        /// <summary>
        /// The three-letter IATA airport code of the flight's destination.
        /// </summary>
        [JsonProperty("arrival_airport_code")]
        public string ArrivalAirportCode { get; set; }

        /// <summary>
        /// The airline carrier code.
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// The three-letter IATA airport code that the flight departed from.
        /// </summary>
        [JsonProperty("departure_airport_code")]
        public string DepartureAirportCode { get; set; }

        /// <summary>
        /// The flight number.
        /// </summary>
        [JsonProperty("flight_number")]
        public string FlightNumber { get; set; }

        /// <summary>
        /// The flight's service class.
        /// </summary>
        [JsonProperty("service_class")]
        public string ServiceClass { get; set; }

        /// <summary>
        /// Whether a stopover is allowed on this flight.
        /// </summary>
        [JsonProperty("stopover_allowed")]
        public bool? StopoverAllowed { get; set; }
    }
}
