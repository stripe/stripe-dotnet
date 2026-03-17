// File generated from our OpenAPI spec
namespace Stripe.Billing.Analytics
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A billing meter usage event represents an aggregated view of a customer’s billing meter
    /// events within a specified timeframe.
    /// </summary>
    public class MeterUsage : StripeEntity<MeterUsage>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// The timestamp to indicate data freshness, measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("refreshed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refreshed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime RefreshedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("rows")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rows")]
#endif
        public StripeList<MeterUsageRow> Rows { get; set; }
    }
}
