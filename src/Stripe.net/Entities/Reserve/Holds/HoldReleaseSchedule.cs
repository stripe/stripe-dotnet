// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class HoldReleaseSchedule : StripeEntity<HoldReleaseSchedule>
    {
        /// <summary>
        /// The time after which the ReserveHold is requested to be released.
        /// </summary>
        [JsonProperty("release_after")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("release_after")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ReleaseAfter { get; set; }

        /// <summary>
        /// The time at which the ReserveHold is scheduled to be released, automatically set to
        /// midnight UTC of the day after <c>release_after</c>.
        /// </summary>
        [JsonProperty("scheduled_release")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("scheduled_release")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ScheduledRelease { get; set; }
    }
}
