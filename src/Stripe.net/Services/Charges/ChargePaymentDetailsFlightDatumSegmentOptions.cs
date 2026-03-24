// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsFlightDatumSegmentOptions : INestedOptions
    {
        /// <summary>
        /// Segment fare amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Arrival details.
        /// </summary>
        [JsonProperty("arrival")]
        [STJS.JsonPropertyName("arrival")]
        public ChargePaymentDetailsFlightDatumSegmentArrivalOptions Arrival { get; set; }

        /// <summary>
        /// Airline carrier code.
        /// </summary>
        [JsonProperty("carrier_code")]
        [STJS.JsonPropertyName("carrier_code")]
        public string CarrierCode { get; set; }

        /// <summary>
        /// Carrier name.
        /// </summary>
        [JsonProperty("carrier_name")]
        [STJS.JsonPropertyName("carrier_name")]
        public string CarrierName { get; set; }

        /// <summary>
        /// Segment currency.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Departure details.
        /// </summary>
        [JsonProperty("departure")]
        [STJS.JsonPropertyName("departure")]
        public ChargePaymentDetailsFlightDatumSegmentDepartureOptions Departure { get; set; }

        /// <summary>
        /// Exchange ticket number.
        /// </summary>
        [JsonProperty("exchange_ticket_number")]
        [STJS.JsonPropertyName("exchange_ticket_number")]
        public string ExchangeTicketNumber { get; set; }

        /// <summary>
        /// Fare basis code.
        /// </summary>
        [JsonProperty("fare_basis_code")]
        [STJS.JsonPropertyName("fare_basis_code")]
        public string FareBasisCode { get; set; }

        /// <summary>
        /// Additional fees.
        /// </summary>
        [JsonProperty("fees")]
        [STJS.JsonPropertyName("fees")]
        public long? Fees { get; set; }

        /// <summary>
        /// Flight number.
        /// </summary>
        [JsonProperty("flight_number")]
        [STJS.JsonPropertyName("flight_number")]
        public string FlightNumber { get; set; }

        /// <summary>
        /// Stopover indicator.
        /// </summary>
        [JsonProperty("is_stop_over_indicator")]
        [STJS.JsonPropertyName("is_stop_over_indicator")]
        public bool? IsStopOverIndicator { get; set; }

        /// <summary>
        /// Refundable ticket indicator.
        /// </summary>
        [JsonProperty("refundable")]
        [STJS.JsonPropertyName("refundable")]
        public bool? Refundable { get; set; }

        /// <summary>
        /// Class of service.
        /// One of: <c>business</c>, <c>economy</c>, <c>first_class</c>, or <c>premium_economy</c>.
        /// </summary>
        [JsonProperty("service_class")]
        [STJS.JsonPropertyName("service_class")]
        public string ServiceClass { get; set; }

        /// <summary>
        /// Tax amount for segment.
        /// </summary>
        [JsonProperty("tax_amount")]
        [STJS.JsonPropertyName("tax_amount")]
        public long? TaxAmount { get; set; }

        /// <summary>
        /// Ticket number.
        /// </summary>
        [JsonProperty("ticket_number")]
        [STJS.JsonPropertyName("ticket_number")]
        public string TicketNumber { get; set; }
    }
}
