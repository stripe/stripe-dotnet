// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionPurchaseDetailsFlight : StripeEntity<TransactionPurchaseDetailsFlight>
    {
        /// <summary>
        /// The time that the flight departed.
        /// </summary>
        [JsonProperty("departure_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("departure_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? DepartureAt { get; set; }

        /// <summary>
        /// The name of the passenger.
        /// </summary>
        [JsonProperty("passenger_name")]
        [STJS.JsonPropertyName("passenger_name")]
        public string PassengerName { get; set; }

        /// <summary>
        /// Whether the ticket is refundable.
        /// </summary>
        [JsonProperty("refundable")]
        [STJS.JsonPropertyName("refundable")]
        public bool? Refundable { get; set; }

        /// <summary>
        /// The legs of the trip.
        /// </summary>
        [JsonProperty("segments")]
        [STJS.JsonPropertyName("segments")]
        public List<TransactionPurchaseDetailsFlightSegment> Segments { get; set; }

        /// <summary>
        /// The travel agency that issued the ticket.
        /// </summary>
        [JsonProperty("travel_agency")]
        [STJS.JsonPropertyName("travel_agency")]
        public string TravelAgency { get; set; }
    }
}
