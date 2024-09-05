// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class MeterErrorReport : StripeEntity<MeterErrorReport>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("reason")]
        public MeterErrorReportReason Reason { get; set; }

        /// <summary>
        /// The related objects about the error.
        /// </summary>
        [JsonProperty("related_object")]
        public MeterErrorReportRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Summary of invalid events.
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Time when validation ended. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("validation_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ValidationEnd { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time when validation started. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("validation_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ValidationStart { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
