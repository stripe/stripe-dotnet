// File generated from our OpenAPI spec
namespace Stripe.Billing.Analytics
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
        /// A set of key-value pairs representing the dimensions of the meter usage.
        /// </summary>
        [JsonProperty("dimensions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dimensions")]
#endif
        public Dictionary<string, string> Dimensions { get; set; }

        /// <summary>
        /// Timestamp indicating the end of the bucket. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("ends_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ends_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime EndsAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The unique identifier for the meter. Null if no meters were provided and usage was
        /// aggregated across all meters.
        /// </summary>
        [JsonProperty("meter")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("meter")]
#endif
        public string Meter { get; set; }

        /// <summary>
        /// Timestamp indicating the start of the bucket. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("starts_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("starts_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime StartsAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A set of key-value pairs representing the tenants of the meter usage.
        /// </summary>
        [JsonProperty("tenants")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tenants")]
#endif
        public Dictionary<string, string> Tenants { get; set; }

        /// <summary>
        /// The aggregated meter usage value for the specified bucket.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public decimal Value { get; set; }
    }
}
