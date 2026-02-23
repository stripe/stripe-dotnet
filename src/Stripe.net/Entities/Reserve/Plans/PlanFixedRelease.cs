// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PlanFixedRelease : StripeEntity<PlanFixedRelease>
    {
        /// <summary>
        /// The time after which all reserved funds are requested for release.
        /// </summary>
        [JsonProperty("release_after")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("release_after")]
#endif
        public long ReleaseAfter { get; set; }

        /// <summary>
        /// The time at which reserved funds are scheduled for release, automatically set to
        /// midnight UTC of the day after <c>release_after</c>.
        /// </summary>
        [JsonProperty("scheduled_release")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("scheduled_release")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ScheduledRelease { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
