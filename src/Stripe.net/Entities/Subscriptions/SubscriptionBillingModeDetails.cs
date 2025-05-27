// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionBillingModeDetails : StripeEntity<SubscriptionBillingModeDetails>
    {
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
