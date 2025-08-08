// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterUsageRow : StripeEntity<MeterUsageRow>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Timestamp indicating the end of the bucket. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("bucket_end_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bucket_end_time")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime BucketEndTime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp indicating the start of the bucket. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("bucket_start_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bucket_start_time")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime BucketStartTime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The aggregated meter usage value for the specified bucket.
        /// </summary>
        [JsonProperty("bucket_value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bucket_value")]
#endif
        public decimal BucketValue { get; set; }

        /// <summary>
        /// A set of key-value pairs representing the dimensions of the meter usage.
        /// </summary>
        [JsonProperty("dimensions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dimensions")]
#endif
        public Dictionary<string, string> Dimensions { get; set; }

        /// <summary>
        /// The unique identifier for the meter. Null if no meters were provided and usage was
        /// aggregated across all meters.
        /// </summary>
        [JsonProperty("meter_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("meter_id")]
#endif
        public string MeterId { get; set; }
    }
}
