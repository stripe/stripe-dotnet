// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsFlightDatum : StripeEntity<PaymentIntentPaymentDetailsFlightDatum>
    {
        [JsonProperty("affiliate")]
        [STJS.JsonPropertyName("affiliate")]
        public PaymentIntentPaymentDetailsFlightDatumAffiliate Affiliate { get; set; }

        /// <summary>
        /// The booking number associated with the flight reservation.
        /// </summary>
        [JsonProperty("booking_number")]
        [STJS.JsonPropertyName("booking_number")]
        public string BookingNumber { get; set; }

        /// <summary>
        /// The computerized reservation system used to make the reservation and purchase the
        /// ticket.
        /// </summary>
        [JsonProperty("computerized_reservation_system")]
        [STJS.JsonPropertyName("computerized_reservation_system")]
        public string ComputerizedReservationSystem { get; set; }

        /// <summary>
        /// Ticket restrictions.
        /// </summary>
        [JsonProperty("endorsements_and_restrictions")]
        [STJS.JsonPropertyName("endorsements_and_restrictions")]
        public string EndorsementsAndRestrictions { get; set; }

        /// <summary>
        /// Insurance details for the flight.
        /// </summary>
        [JsonProperty("insurances")]
        [STJS.JsonPropertyName("insurances")]
        public List<PaymentIntentPaymentDetailsFlightDatumInsurance> Insurances { get; set; }

        /// <summary>
        /// The list of passengers for this flight.
        /// </summary>
        [JsonProperty("passengers")]
        [STJS.JsonPropertyName("passengers")]
        public List<PaymentIntentPaymentDetailsFlightDatumPassenger> Passengers { get; set; }

        /// <summary>
        /// The list of flight segments for this reservation.
        /// </summary>
        [JsonProperty("segments")]
        [STJS.JsonPropertyName("segments")]
        public List<PaymentIntentPaymentDetailsFlightDatumSegment> Segments { get; set; }

        /// <summary>
        /// Electronic ticket indicator.
        /// </summary>
        [JsonProperty("ticket_electronically_issued_indicator")]
        [STJS.JsonPropertyName("ticket_electronically_issued_indicator")]
        public bool TicketElectronicallyIssuedIndicator { get; set; }

        [JsonProperty("total")]
        [STJS.JsonPropertyName("total")]
        public PaymentIntentPaymentDetailsFlightDatumTotal Total { get; set; }

        /// <summary>
        /// Type of flight transaction.
        /// One of: <c>exchange_ticket</c>, <c>miscellaneous</c>, <c>refund</c>, or
        /// <c>ticket_purchase</c>.
        /// </summary>
        [JsonProperty("transaction_type")]
        [STJS.JsonPropertyName("transaction_type")]
        public string TransactionType { get; set; }
    }
}
