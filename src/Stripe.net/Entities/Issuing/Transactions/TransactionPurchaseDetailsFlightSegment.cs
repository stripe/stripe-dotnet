namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TransactionPurchaseDetailsFlightSegment : StripeEntity<TransactionPurchaseDetailsFlightSegment>
    {
        [JsonProperty("arrival_airport_code")]
        public string ArrivalAirportCode { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("departure_airport_code")]
        public string DepartureAirportCode { get; set; }

        [JsonProperty("flight_number")]
        public string FlightNumber { get; set; }

        [JsonProperty("service_class")]
        public string ServiceClass { get; set; }

        [JsonProperty("stopover_allowed")]
        public bool? StopoverAllowed { get; set; }
    }
}
