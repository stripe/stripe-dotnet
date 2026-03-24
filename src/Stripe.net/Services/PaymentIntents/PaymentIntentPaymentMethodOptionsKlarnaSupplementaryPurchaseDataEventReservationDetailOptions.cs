// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataEventReservationDetailOptions : INestedOptions
    {
        /// <summary>
        /// Indicates if the tickets are digitally checked when entering the venue.
        /// </summary>
        [JsonProperty("access_controlled_venue")]
        [STJS.JsonPropertyName("access_controlled_venue")]
        public bool? AccessControlledVenue { get; set; }

        /// <summary>
        /// Address of the event.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataEventReservationDetailAddressOptions Address { get; set; }

        /// <summary>
        /// Name of associated or partner company for the service.
        /// </summary>
        [JsonProperty("affiliate_name")]
        [STJS.JsonPropertyName("affiliate_name")]
        public string AffiliateName { get; set; }

        /// <summary>
        /// End timestamp of the event.
        /// </summary>
        [JsonProperty("ends_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("ends_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? EndsAt { get; set; }

        /// <summary>
        /// Company selling the ticket.
        /// </summary>
        [JsonProperty("event_company_name")]
        [STJS.JsonPropertyName("event_company_name")]
        public string EventCompanyName { get; set; }

        /// <summary>
        /// Name of the event.
        /// </summary>
        [JsonProperty("event_name")]
        [STJS.JsonPropertyName("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// Type of the event.
        /// One of: <c>concert</c>, <c>conference</c>, <c>digital_education</c>, <c>expo</c>,
        /// <c>festival</c>, <c>in_person_education</c>, <c>sport</c>, or <c>tour</c>.
        /// </summary>
        [JsonProperty("event_type")]
        [STJS.JsonPropertyName("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// List of insurances for this event.
        /// </summary>
        [JsonProperty("insurances")]
        [STJS.JsonPropertyName("insurances")]
        public List<PaymentIntentPaymentMethodOptionsKlarnaSupplementaryPurchaseDataEventReservationDetailInsuranceOptions> Insurances { get; set; }

        /// <summary>
        /// Start timestamp of the event.
        /// </summary>
        [JsonProperty("starts_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("starts_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? StartsAt { get; set; }

        /// <summary>
        /// Name of the venue where the event takes place.
        /// </summary>
        [JsonProperty("venue_name")]
        [STJS.JsonPropertyName("venue_name")]
        public string VenueName { get; set; }
    }
}
