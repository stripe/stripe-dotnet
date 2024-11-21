// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class UsageRecordSummaryPeriod : StripeEntity<UsageRecordSummaryPeriod>
    {
        /// <summary>
        /// The end date of this usage period. All usage up to and including this point in time is
        /// included.
        /// </summary>
        [JsonProperty("end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? End { get; set; }

        /// <summary>
        /// The start date of this usage period. All usage after this point in time is included.
        /// </summary>
        [JsonProperty("start")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("start")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? Start { get; set; }
    }
}
