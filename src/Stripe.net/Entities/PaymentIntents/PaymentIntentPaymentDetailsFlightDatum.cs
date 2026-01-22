// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsFlightDatum : StripeEntity<PaymentIntentPaymentDetailsFlightDatum>
    {
        [JsonProperty("affiliate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate")]
#endif
        public PaymentIntentPaymentDetailsFlightDatumAffiliate Affiliate { get; set; }

        /// <summary>
        /// The booking number associated with the flight reservation.
        /// </summary>
        [JsonProperty("booking_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("booking_number")]
#endif
        public string BookingNumber { get; set; }

        /// <summary>
        /// The computerized reservation system used to make the reservation and purchase the
        /// ticket.
        /// </summary>
        [JsonProperty("computerized_reservation_system")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("computerized_reservation_system")]
#endif
        public string ComputerizedReservationSystem { get; set; }

        /// <summary>
        /// Ticket restrictions.
        /// </summary>
        [JsonProperty("endorsements_and_restrictions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("endorsements_and_restrictions")]
#endif
        public string EndorsementsAndRestrictions { get; set; }

        /// <summary>
        /// Insurance details for the flight.
        /// </summary>
        [JsonProperty("insurances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("insurances")]
#endif
        public List<PaymentIntentPaymentDetailsFlightDatumInsurance> Insurances { get; set; }

        /// <summary>
        /// The list of passengers for this flight.
        /// </summary>
        [JsonProperty("passengers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("passengers")]
#endif
        public List<PaymentIntentPaymentDetailsFlightDatumPassenger> Passengers { get; set; }

        /// <summary>
        /// The list of flight segments for this reservation.
        /// </summary>
        [JsonProperty("segments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("segments")]
#endif
        public List<PaymentIntentPaymentDetailsFlightDatumSegment> Segments { get; set; }

        /// <summary>
        /// Electronic ticket indicator.
        /// </summary>
        [JsonProperty("ticket_electronically_issued_indicator")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ticket_electronically_issued_indicator")]
#endif
        public bool TicketElectronicallyIssuedIndicator { get; set; }

        [JsonProperty("total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total")]
#endif
        public PaymentIntentPaymentDetailsFlightDatumTotal Total { get; set; }

        /// <summary>
        /// Type of flight transaction.
        /// One of: <c>exchange_ticket</c>, <c>miscellaneous</c>, <c>refund</c>, or
        /// <c>ticket_purchase</c>.
        /// </summary>
        [JsonProperty("transaction_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_type")]
#endif
        public string TransactionType { get; set; }
    }
}
