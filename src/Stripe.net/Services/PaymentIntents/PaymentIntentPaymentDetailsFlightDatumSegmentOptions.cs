// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsFlightDatumSegmentOptions : INestedOptions
    {
        /// <summary>
        /// Segment fare amount.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Arrival details.
        /// </summary>
        [JsonProperty("arrival")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("arrival")]
#endif
        public PaymentIntentPaymentDetailsFlightDatumSegmentArrivalOptions Arrival { get; set; }

        /// <summary>
        /// Airline carrier code.
        /// </summary>
        [JsonProperty("carrier_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("carrier_code")]
#endif
        public string CarrierCode { get; set; }

        /// <summary>
        /// Carrier name.
        /// </summary>
        [JsonProperty("carrier_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("carrier_name")]
#endif
        public string CarrierName { get; set; }

        /// <summary>
        /// Segment currency.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Departure details.
        /// </summary>
        [JsonProperty("departure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("departure")]
#endif
        public PaymentIntentPaymentDetailsFlightDatumSegmentDepartureOptions Departure { get; set; }

        /// <summary>
        /// Exchange ticket number.
        /// </summary>
        [JsonProperty("exchange_ticket_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exchange_ticket_number")]
#endif
        public string ExchangeTicketNumber { get; set; }

        /// <summary>
        /// Fare basis code.
        /// </summary>
        [JsonProperty("fare_basis_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fare_basis_code")]
#endif
        public string FareBasisCode { get; set; }

        /// <summary>
        /// Additional fees.
        /// </summary>
        [JsonProperty("fees")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fees")]
#endif
        public long? Fees { get; set; }

        /// <summary>
        /// Flight number.
        /// </summary>
        [JsonProperty("flight_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flight_number")]
#endif
        public string FlightNumber { get; set; }

        /// <summary>
        /// Stopover indicator.
        /// </summary>
        [JsonProperty("is_stop_over_indicator")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_stop_over_indicator")]
#endif
        public bool? IsStopOverIndicator { get; set; }

        /// <summary>
        /// Refundable ticket indicator.
        /// </summary>
        [JsonProperty("refundable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refundable")]
#endif
        public bool? Refundable { get; set; }

        /// <summary>
        /// Class of service.
        /// One of: <c>business</c>, <c>economy</c>, <c>first_class</c>, or <c>premium_economy</c>.
        /// </summary>
        [JsonProperty("service_class")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_class")]
#endif
        public string ServiceClass { get; set; }

        /// <summary>
        /// Tax amount for segment.
        /// </summary>
        [JsonProperty("tax_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_amount")]
#endif
        public long? TaxAmount { get; set; }

        /// <summary>
        /// Ticket number.
        /// </summary>
        [JsonProperty("ticket_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ticket_number")]
#endif
        public string TicketNumber { get; set; }
    }
}
