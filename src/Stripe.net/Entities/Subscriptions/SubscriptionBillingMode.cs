// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionBillingMode : StripeEntity<SubscriptionBillingMode>
    {
        /// <summary>
        /// Configure behavior for flexible billing mode.
        /// </summary>
        [JsonProperty("flexible")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flexible")]
#endif
        public SubscriptionBillingModeFlexible Flexible { get; set; }

        /// <summary>
        /// Controls how prorations and invoices for subscriptions are calculated and orchestrated.
        /// One of: <c>classic</c>, or <c>flexible</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Details on when the current billing_mode was adopted.
        /// </summary>
        [JsonProperty("updated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("updated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime UpdatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
