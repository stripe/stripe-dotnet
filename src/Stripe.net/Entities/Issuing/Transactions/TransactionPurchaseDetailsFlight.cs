namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionPurchaseDetailsFlight : StripeEntity<TransactionPurchaseDetailsFlight>
    {
        /// <summary>
        /// The time that the flight departed.
        /// </summary>
        [JsonProperty("departure_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? DepartureAt { get; set; }

        /// <summary>
        /// The name of the passenger.
        /// </summary>
        [JsonProperty("passenger_name")]
        public string PassengerName { get; set; }

        /// <summary>
        /// Whether the ticket is refundable.
        /// </summary>
        [JsonProperty("refundable")]
        public bool? Refundable { get; set; }

        /// <summary>
        /// The legs of the trip.
        /// </summary>
        [JsonProperty("segments")]
        public List<TransactionPurchaseDetailsFlightSegment> Segments { get; set; }

        /// <summary>
        /// The travel agency that issued the ticket.
        /// </summary>
        [JsonProperty("travel_agency")]
        public string TravelAgency { get; set; }
    }
}
