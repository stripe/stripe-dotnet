// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentDetailsSubscriptionOptions : INestedOptions
    {
        /// <summary>
        /// Affiliate details for this purchase.
        /// </summary>
        [JsonProperty("affiliate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate")]
#endif
        public ChargePaymentDetailsSubscriptionAffiliateOptions Affiliate { get; set; }

        /// <summary>
        /// Info whether the subscription will be auto renewed upon expiry.
        /// </summary>
        [JsonProperty("auto_renewal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("auto_renewal")]
#endif
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// Subscription billing details for this purchase.
        /// </summary>
        [JsonProperty("billing_interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_interval")]
#endif
        public ChargePaymentDetailsSubscriptionBillingIntervalOptions BillingInterval { get; set; }

        /// <summary>
        /// Subscription end time. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("ends_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ends_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? EndsAt { get; set; }

        /// <summary>
        /// Name of the product on subscription. e.g. Apple Music Subscription.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Subscription start time. Measured in seconds since the Unix epoch.
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
