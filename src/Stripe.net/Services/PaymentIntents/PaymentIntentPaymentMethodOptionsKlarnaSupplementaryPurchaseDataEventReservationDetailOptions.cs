// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataEventReservationDetailOptions : INestedOptions
    {
        /// <summary>
        /// Indicates if the tickets are digitally checked when entering the venue.
        /// </summary>
        [JsonProperty("access_controlled_venue")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("access_controlled_venue")]
#endif
        public bool? AccessControlledVenue { get; set; }

        /// <summary>
        /// Address of the event.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataEventReservationDetailAddressOptions Address { get; set; }

        /// <summary>
        /// Name of associated or partner company for the service.
        /// </summary>
        [JsonProperty("affiliate_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate_name")]
#endif
        public string AffiliateName { get; set; }

        /// <summary>
        /// End timestamp of the event.
        /// </summary>
        [JsonProperty("ends_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ends_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? EndsAt { get; set; }

        /// <summary>
        /// Company selling the ticket.
        /// </summary>
        [JsonProperty("event_company_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_company_name")]
#endif
        public string EventCompanyName { get; set; }

        /// <summary>
        /// Name of the event.
        /// </summary>
        [JsonProperty("event_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_name")]
#endif
        public string EventName { get; set; }

        /// <summary>
        /// Type of the event.
        /// One of: <c>concert</c>, <c>conference</c>, <c>digital_education</c>, <c>expo</c>,
        /// <c>festival</c>, <c>in_person_education</c>, <c>sport</c>, or <c>tour</c>.
        /// </summary>
        [JsonProperty("event_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("event_type")]
#endif
        public string EventType { get; set; }

        /// <summary>
        /// List of insurances for this event.
        /// </summary>
        [JsonProperty("insurances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("insurances")]
#endif
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataEventReservationDetailInsuranceOptions> Insurances { get; set; }

        /// <summary>
        /// Start timestamp of the event.
        /// </summary>
        [JsonProperty("starts_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("starts_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? StartsAt { get; set; }

        /// <summary>
        /// Name of the venue where the event takes place.
        /// </summary>
        [JsonProperty("venue_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("venue_name")]
#endif
        public string VenueName { get; set; }
    }
}
