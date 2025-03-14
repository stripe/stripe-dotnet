// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsEventDetailsOptions : INestedOptions
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
        /// The event location's address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Affiliate details for this purchase.
        /// </summary>
        [JsonProperty("affiliate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate")]
#endif
        public PaymentIntentPaymentDetailsEventDetailsAffiliateOptions Affiliate { get; set; }

        /// <summary>
        /// The name of the company.
        /// </summary>
        [JsonProperty("company")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company")]
#endif
        public string Company { get; set; }

        /// <summary>
        /// Delivery details for this purchase.
        /// </summary>
        [JsonProperty("delivery")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivery")]
#endif
        public PaymentIntentPaymentDetailsEventDetailsDeliveryOptions Delivery { get; set; }

        /// <summary>
        /// Event end time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("ends_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ends_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? EndsAt { get; set; }

        /// <summary>
        /// Type of the event entertainment (concert, sports event etc).
        /// </summary>
        [JsonProperty("genre")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("genre")]
#endif
        public string Genre { get; set; }

        /// <summary>
        /// The name of the event.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Event start time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("starts_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("starts_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? StartsAt { get; set; }
    }
}
