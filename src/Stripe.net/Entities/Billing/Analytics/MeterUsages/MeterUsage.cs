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
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Timestamp indicating how fresh the data is. Measured in seconds since the Unix epoch.
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
