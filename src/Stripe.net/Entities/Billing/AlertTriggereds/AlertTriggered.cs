// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertTriggered : StripeEntity<AlertTriggered>, IHasObject
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
        /// The aggregation period for which this alert triggered.
        /// </summary>
        [JsonProperty("aggregation_period")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("aggregation_period")]
#endif
        public AlertTriggeredAggregationPeriod AggregationPeriod { get; set; }

        /// <summary>
        /// A billing alert is a resource that notifies you when a certain usage threshold on a
        /// meter is crossed. For example, you might create a billing alert to notify you when a
        /// certain user made 100 API requests.
        /// </summary>
        [JsonProperty("alert")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alert")]
#endif
        public Alert Alert { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Currency for the threshold value.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Custom pricing unit for the threshold value.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit")]
#endif
        public string CustomPricingUnit { get; set; }

        /// <summary>
        /// ID of customer for which the alert triggered.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// External customer ID for the customer for which the alert triggered.
        /// </summary>
        [JsonProperty("external_customer_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("external_customer_id")]
#endif
        public string ExternalCustomerId { get; set; }

        /// <summary>
        /// Populated specifically for spend alerts to notify merchants which group_by entity has
        /// the exceeded spend.
        /// </summary>
        [JsonProperty("group_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("group_by")]
#endif
        public AlertTriggeredGroupBy GroupBy { get; set; }

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
        /// Timestamp at which the threshold was crossed.
        /// </summary>
        [JsonProperty("triggered_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("triggered_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? TriggeredAt { get; set; }

        /// <summary>
        /// The value triggering the alert.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public decimal Value { get; set; }
    }
}
