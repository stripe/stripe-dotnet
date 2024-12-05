// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentDetailsSubscriptionOptions : INestedOptions
    {
        /// <summary>
        /// Affiliate details for this purchase.
        /// </summary>
        [JsonProperty("affiliate")]
        public PaymentIntentPaymentDetailsSubscriptionAffiliateOptions Affiliate { get; set; }

        /// <summary>
        /// Info whether the subscription will be auto renewed upon expiry.
        /// </summary>
        [JsonProperty("auto_renewal")]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// Subscription billing details for this purchase.
        /// </summary>
        [JsonProperty("billing_interval")]
        public PaymentIntentPaymentDetailsSubscriptionBillingIntervalOptions BillingInterval { get; set; }

        /// <summary>
        /// Subscription end time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("ends_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndsAt { get; set; }

        /// <summary>
        /// Name of the product on subscription. e.g. Apple Music Subscription.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Subscription start time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("starts_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? StartsAt { get; set; }
    }
}
