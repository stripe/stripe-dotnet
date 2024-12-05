// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentDetailsEventDetails : StripeEntity<PaymentIntentPaymentDetailsEventDetails>
    {
        /// <summary>
        /// Indicates if the tickets are digitally checked when entering the venue.
        /// </summary>
        [JsonProperty("access_controlled_venue")]
        public bool AccessControlledVenue { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("affiliate")]
        public PaymentIntentPaymentDetailsEventDetailsAffiliate Affiliate { get; set; }

        /// <summary>
        /// The name of the company.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("delivery")]
        public PaymentIntentPaymentDetailsEventDetailsDelivery Delivery { get; set; }

        /// <summary>
        /// Event end time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("ends_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime EndsAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        public DateTime StartsAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
