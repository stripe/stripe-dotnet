// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsFlightDatumOptions : INestedOptions
    {
        /// <summary>
        /// Affiliate details if applicable.
        /// </summary>
        [JsonProperty("affiliate")]
        [STJS.JsonPropertyName("affiliate")]
        public PaymentIntentPaymentDetailsFlightDatumAffiliateOptions Affiliate { get; set; }

        /// <summary>
        /// Reservation reference.
        /// </summary>
        [JsonProperty("booking_number")]
        [STJS.JsonPropertyName("booking_number")]
        public string BookingNumber { get; set; }

        /// <summary>
        /// Computerized reservation system used to make the reservation and purchase the ticket.
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
        /// List of insurances.
        /// </summary>
        [JsonProperty("insurances")]
        [STJS.JsonPropertyName("insurances")]
        public List<PaymentIntentPaymentDetailsFlightDatumInsuranceOptions> Insurances { get; set; }

        /// <summary>
        /// List of passengers.
        /// </summary>
        [JsonProperty("passengers")]
        [STJS.JsonPropertyName("passengers")]
        public List<PaymentIntentPaymentDetailsFlightDatumPassengerOptions> Passengers { get; set; }

        /// <summary>
        /// List of flight segments.
        /// </summary>
        [JsonProperty("segments")]
        [STJS.JsonPropertyName("segments")]
        public List<PaymentIntentPaymentDetailsFlightDatumSegmentOptions> Segments { get; set; }

        /// <summary>
        /// Electronic ticket indicator.
        /// </summary>
        [JsonProperty("ticket_electronically_issued_indicator")]
        [STJS.JsonPropertyName("ticket_electronically_issued_indicator")]
        public bool? TicketElectronicallyIssuedIndicator { get; set; }

        /// <summary>
        /// Total cost breakdown.
        /// </summary>
        [JsonProperty("total")]
        [STJS.JsonPropertyName("total")]
        public PaymentIntentPaymentDetailsFlightDatumTotalOptions Total { get; set; }

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
