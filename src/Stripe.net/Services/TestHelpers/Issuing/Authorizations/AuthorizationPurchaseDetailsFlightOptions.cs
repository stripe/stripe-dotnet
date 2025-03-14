// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationPurchaseDetailsFlightOptions : INestedOptions
    {
        /// <summary>
        /// The time that the flight departed.
        /// </summary>
        [JsonProperty("departure_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("departure_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? DepartureAt { get; set; }

        /// <summary>
        /// The name of the passenger.
        /// </summary>
        [JsonProperty("passenger_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("passenger_name")]
#endif
        public string PassengerName { get; set; }

        /// <summary>
        /// Whether the ticket is refundable.
        /// </summary>
        [JsonProperty("refundable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refundable")]
#endif
        public bool? Refundable { get; set; }

        /// <summary>
        /// The legs of the trip.
        /// </summary>
        [JsonProperty("segments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("segments")]
#endif
        public List<AuthorizationPurchaseDetailsFlightSegmentOptions> Segments { get; set; }

        /// <summary>
        /// The travel agency that issued the ticket.
        /// </summary>
        [JsonProperty("travel_agency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("travel_agency")]
#endif
        public string TravelAgency { get; set; }
    }
}
