// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ChargePaymentDetailsFlightOptions : INestedOptions
    {
        /// <summary>
        /// The agency number (i.e. International Air Transport Association (IATA) agency number) of
        /// the travel agency that made the booking.
        /// </summary>
        [JsonProperty("agency_number")]
        public string AgencyNumber { get; set; }

        /// <summary>
        /// The International Air Transport Association (IATA) carrier code of the carrier that
        /// issued the ticket.
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// The name of the person or entity on the reservation.
        /// </summary>
        [JsonProperty("passenger_name")]
        public string PassengerName { get; set; }

        /// <summary>
        /// The individual flight segments associated with the trip.
        /// </summary>
        [JsonProperty("segments")]
        public List<ChargePaymentDetailsFlightSegmentOptions> Segments { get; set; }

        /// <summary>
        /// The ticket number associated with the travel reservation.
        /// </summary>
        [JsonProperty("ticket_number")]
        public string TicketNumber { get; set; }
    }
}
