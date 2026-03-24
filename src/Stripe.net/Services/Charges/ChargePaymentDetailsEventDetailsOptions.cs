// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsEventDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Indicates if the tickets are digitally checked when entering the venue.
        /// </summary>
        [JsonProperty("access_controlled_venue")]
        [STJS.JsonPropertyName("access_controlled_venue")]
        public bool? AccessControlledVenue { get; set; }

        /// <summary>
        /// The event location's address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Affiliate details for this purchase.
        /// </summary>
        [JsonProperty("affiliate")]
        [STJS.JsonPropertyName("affiliate")]
        public ChargePaymentDetailsEventDetailsAffiliateOptions Affiliate { get; set; }

        /// <summary>
        /// The name of the company.
        /// </summary>
        [JsonProperty("company")]
        [STJS.JsonPropertyName("company")]
        public string Company { get; set; }

        /// <summary>
        /// Delivery details for this purchase.
        /// </summary>
        [JsonProperty("delivery")]
        [STJS.JsonPropertyName("delivery")]
        public ChargePaymentDetailsEventDetailsDeliveryOptions Delivery { get; set; }

        /// <summary>
        /// Event end time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("ends_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("ends_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? EndsAt { get; set; }

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
        public DateTime? StartsAt { get; set; }
    }
}
