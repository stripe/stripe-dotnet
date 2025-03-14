// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterErrorReport : StripeEntity<MeterErrorReport>, IHasId, IHasObject
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

        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public MeterErrorReportReason Reason { get; set; }

        /// <summary>
        /// The related objects about the error.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif
        public MeterErrorReportRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Summary of invalid events.
        /// </summary>
        [JsonProperty("summary")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("summary")]
#endif
        public string Summary { get; set; }

        /// <summary>
        /// Time when validation ended. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("validation_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validation_end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ValidationEnd { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time when validation started. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("validation_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validation_start")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ValidationStart { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
