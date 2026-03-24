// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PlanFixedRelease : StripeEntity<PlanFixedRelease>
    {
        /// <summary>
        /// The time after which all reserved funds are requested for release.
        /// </summary>
        [JsonProperty("release_after")]
        [STJS.JsonPropertyName("release_after")]
        public long ReleaseAfter { get; set; }

        /// <summary>
        /// The time at which reserved funds are scheduled for release, automatically set to
        /// midnight UTC of the day after <c>release_after</c>.
        /// </summary>
        [JsonProperty("scheduled_release")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("scheduled_release")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ScheduledRelease { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
