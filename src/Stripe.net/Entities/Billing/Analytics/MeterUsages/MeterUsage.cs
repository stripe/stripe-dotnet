// File generated from our OpenAPI spec
namespace Stripe.Billing.Analytics
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A billing meter usage event represents an aggregated view of a customer’s billing meter
    /// events within a specified timeframe.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class MeterUsage : StripeEntity<MeterUsage>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The timestamp to indicate data freshness, measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("refreshed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("refreshed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime RefreshedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("rows")]
        [STJS.JsonPropertyName("rows")]
        public StripeList<MeterUsageRow> Rows { get; set; }
    }
}
