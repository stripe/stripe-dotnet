// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsEventDetails : StripeEntity<PaymentIntentPaymentDetailsEventDetails>
    {
        /// <summary>
        /// Indicates if the tickets are digitally checked when entering the venue.
        /// </summary>
        [JsonProperty("access_controlled_venue")]
        [STJS.JsonPropertyName("access_controlled_venue")]
        public bool AccessControlledVenue { get; set; }

        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public Address Address { get; set; }

        [JsonProperty("affiliate")]
        [STJS.JsonPropertyName("affiliate")]
        public PaymentIntentPaymentDetailsEventDetailsAffiliate Affiliate { get; set; }

        /// <summary>
        /// The name of the company.
        /// </summary>
        [JsonProperty("company")]
        [STJS.JsonPropertyName("company")]
        public string Company { get; set; }

        [JsonProperty("delivery")]
        [STJS.JsonPropertyName("delivery")]
        public PaymentIntentPaymentDetailsEventDetailsDelivery Delivery { get; set; }

        /// <summary>
        /// Event end time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("ends_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("ends_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime EndsAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Type of the event entertainment (concert, sports event etc).
        /// </summary>
        [JsonProperty("genre")]
        [STJS.JsonPropertyName("genre")]
        public string Genre { get; set; }

        /// <summary>
        /// The name of the event.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Event start time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("starts_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("starts_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime StartsAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
