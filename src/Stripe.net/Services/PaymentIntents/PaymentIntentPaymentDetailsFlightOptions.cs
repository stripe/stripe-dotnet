// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsFlightOptions : INestedOptions
    {
        /// <summary>
        /// Affiliate details for this purchase.
        /// </summary>
        [JsonProperty("affiliate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate")]
#endif
        public PaymentIntentPaymentDetailsFlightAffiliateOptions Affiliate { get; set; }

        /// <summary>
        /// The agency number (i.e. International Air Transport Association (IATA) agency number) of
        /// the travel agency that made the booking.
        /// </summary>
        [JsonProperty("agency_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("agency_number")]
#endif
        public string AgencyNumber { get; set; }

        /// <summary>
        /// The International Air Transport Association (IATA) carrier code of the carrier that
        /// issued the ticket.
        /// </summary>
        [JsonProperty("carrier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("carrier")]
#endif
        public string Carrier { get; set; }

        /// <summary>
        /// Delivery details for this purchase.
        /// </summary>
        [JsonProperty("delivery")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivery")]
#endif
        public PaymentIntentPaymentDetailsFlightDeliveryOptions Delivery { get; set; }

        /// <summary>
        /// The name of the person or entity on the reservation.
        /// </summary>
        [JsonProperty("passenger_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("passenger_name")]
#endif
        public string PassengerName { get; set; }

        /// <summary>
        /// The details of the passengers in the travel reservation.
        /// </summary>
        [JsonProperty("passengers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("passengers")]
#endif
        public List<PaymentIntentPaymentDetailsFlightPassengerOptions> Passengers { get; set; }

        /// <summary>
        /// The individual flight segments associated with the trip.
        /// </summary>
        [JsonProperty("segments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("segments")]
#endif
        public List<PaymentIntentPaymentDetailsFlightSegmentOptions> Segments { get; set; }

        /// <summary>
        /// The ticket number associated with the travel reservation.
        /// </summary>
        [JsonProperty("ticket_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ticket_number")]
#endif
        public string TicketNumber { get; set; }
    }
}
