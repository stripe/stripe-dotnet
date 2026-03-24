// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsSubscription : StripeEntity<PaymentIntentPaymentDetailsSubscription>
    {
        [JsonProperty("affiliate")]
        [STJS.JsonPropertyName("affiliate")]
        public PaymentIntentPaymentDetailsSubscriptionAffiliate Affiliate { get; set; }

        /// <summary>
        /// Info whether the subscription will be auto renewed upon expiry.
        /// </summary>
        [JsonProperty("auto_renewal")]
        [STJS.JsonPropertyName("auto_renewal")]
        public bool AutoRenewal { get; set; }

        [JsonProperty("billing_interval")]
        [STJS.JsonPropertyName("billing_interval")]
        public PaymentIntentPaymentDetailsSubscriptionBillingInterval BillingInterval { get; set; }

        /// <summary>
        /// Subscription end time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("ends_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("ends_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime EndsAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Name of the product on subscription. e.g. Apple Music Subscription.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Subscription start time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("starts_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("starts_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime StartsAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
