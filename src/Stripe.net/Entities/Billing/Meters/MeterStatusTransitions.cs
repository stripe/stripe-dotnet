// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterStatusTransitions : StripeEntity<MeterStatusTransitions>
    {
        /// <summary>
        /// The time the meter was deactivated, if any. Measured in seconds since Unix epoch.
        /// </summary>
        [JsonProperty("deactivated_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deactivated_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? DeactivatedAt { get; set; }
    }
}
