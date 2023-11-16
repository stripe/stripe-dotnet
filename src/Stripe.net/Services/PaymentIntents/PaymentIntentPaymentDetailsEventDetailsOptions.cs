// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentDetailsEventDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Indicates if the tickets are digitally checked when entering the venue.
        /// </summary>
        [JsonProperty("access_controlled_venue")]
        public bool? AccessControlledVenue { get; set; }

        /// <summary>
        /// The event location's address.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Affiliate details for this purchase.
        /// </summary>
        [JsonProperty("affiliate")]
        public PaymentIntentPaymentDetailsEventDetailsAffiliateOptions Affiliate { get; set; }

        /// <summary>
        /// The name of the company.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// Delivery details for this purchase.
        /// </summary>
        [JsonProperty("delivery")]
        public PaymentIntentPaymentDetailsEventDetailsDeliveryOptions Delivery { get; set; }

        /// <summary>
        /// Event end time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("ends_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndsAt { get; set; }

        /// <summary>
        /// Type of the event entertainment (concert, sports event etc).
        /// </summary>
        [JsonProperty("genre")]
        public string Genre { get; set; }

        /// <summary>
        /// The name of the event.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Event start time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("starts_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? StartsAt { get; set; }
    }
}
