// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertTriggered : StripeEntity<AlertTriggered>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The aggregation period for which this alert triggered.
        /// </summary>
        [JsonProperty("aggregation_period")]
        [STJS.JsonPropertyName("aggregation_period")]
        public AlertTriggeredAggregationPeriod AggregationPeriod { get; set; }

        /// <summary>
        /// A billing alert is a resource that notifies you when a certain usage threshold on a
        /// meter is crossed. For example, you might create a billing alert to notify you when a
        /// certain user made 100 API requests.
        /// </summary>
        [JsonProperty("alert")]
        [STJS.JsonPropertyName("alert")]
        public Alert Alert { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Currency for the threshold value.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Custom pricing unit for the threshold value.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
        [STJS.JsonPropertyName("custom_pricing_unit")]
        public string CustomPricingUnit { get; set; }

        /// <summary>
        /// ID of customer for which the alert triggered.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// External customer ID for the customer for which the alert triggered.
        /// </summary>
        [JsonProperty("external_customer_id")]
        [STJS.JsonPropertyName("external_customer_id")]
        public string ExternalCustomerId { get; set; }

        /// <summary>
        /// Populated specifically for spend alerts to notify merchants which group_by entity has
        /// the exceeded spend.
        /// </summary>
        [JsonProperty("group_by")]
        [STJS.JsonPropertyName("group_by")]
        public AlertTriggeredGroupBy GroupBy { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Timestamp at which the threshold was crossed.
        /// </summary>
        [JsonProperty("triggered_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("triggered_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? TriggeredAt { get; set; }

        /// <summary>
        /// The value triggering the alert.
        /// </summary>
        [JsonProperty("value")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("value")]
        public decimal Value { get; set; }
    }
}
