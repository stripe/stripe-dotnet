// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class HoldReleaseSchedule : StripeEntity<HoldReleaseSchedule>
    {
        /// <summary>
        /// The time after which the ReserveHold is requested to be released.
        /// </summary>
        [JsonProperty("release_after")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("release_after")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ReleaseAfter { get; set; }

        /// <summary>
        /// The time at which the ReserveHold is scheduled to be released, automatically set to
        /// midnight UTC of the day after <c>release_after</c>.
        /// </summary>
        [JsonProperty("scheduled_release")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("scheduled_release")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ScheduledRelease { get; set; }
    }
}
