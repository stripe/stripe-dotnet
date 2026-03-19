// File generated from our OpenAPI spec
namespace Stripe.Billing.Analytics
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class MeterUsageRow : StripeEntity<MeterUsageRow>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// A set of key-value pairs representing the dimensions of the meter usage.
        /// </summary>
        [JsonProperty("dimensions")]
        [STJS.JsonPropertyName("dimensions")]
        public Dictionary<string, string> Dimensions { get; set; }

        /// <summary>
        /// Timestamp indicating the end of the bucket. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("ends_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("ends_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime EndsAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The unique identifier for the meter. Null if no meters were provided and usage was
        /// aggregated across all meters.
        /// </summary>
        [JsonProperty("meter")]
        [STJS.JsonPropertyName("meter")]
        public string Meter { get; set; }

        /// <summary>
        /// Timestamp indicating the start of the bucket. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("starts_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("starts_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime StartsAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The aggregated meter usage value for the specified bucket.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public decimal Value { get; set; }
    }
}
