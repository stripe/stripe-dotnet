// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentDetailsFlightDatumOptions : INestedOptions
    {
        /// <summary>
        /// Affiliate details if applicable.
        /// </summary>
        [JsonProperty("affiliate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate")]
#endif
        public ChargePaymentDetailsFlightDatumAffiliateOptions Affiliate { get; set; }

        /// <summary>
        /// Reservation reference.
        /// </summary>
        [JsonProperty("booking_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("booking_number")]
#endif
        public string BookingNumber { get; set; }

        /// <summary>
        /// Computerized reservation system used to make the reservation and purchase the ticket.
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
        /// List of insurances.
        /// </summary>
        [JsonProperty("insurances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("insurances")]
#endif
        public List<ChargePaymentDetailsFlightDatumInsuranceOptions> Insurances { get; set; }

        /// <summary>
        /// List of passengers.
        /// </summary>
        [JsonProperty("passengers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("passengers")]
#endif
        public List<ChargePaymentDetailsFlightDatumPassengerOptions> Passengers { get; set; }

        /// <summary>
        /// List of flight segments.
        /// </summary>
        [JsonProperty("segments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("segments")]
#endif
        public List<ChargePaymentDetailsFlightDatumSegmentOptions> Segments { get; set; }

        /// <summary>
        /// Electronic ticket indicator.
        /// </summary>
        [JsonProperty("ticket_electronically_issued_indicator")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ticket_electronically_issued_indicator")]
#endif
        public bool? TicketElectronicallyIssuedIndicator { get; set; }

        /// <summary>
        /// Total cost breakdown.
        /// </summary>
        [JsonProperty("total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total")]
#endif
        public ChargePaymentDetailsFlightDatumTotalOptions Total { get; set; }

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
