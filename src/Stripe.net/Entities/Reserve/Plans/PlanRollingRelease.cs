// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PlanRollingRelease : StripeEntity<PlanRollingRelease>
    {
        /// <summary>
        /// The number of days to reserve funds before releasing.
        /// </summary>
        [JsonProperty("days_after_charge")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("days_after_charge")]
#endif
        public long DaysAfterCharge { get; set; }

        /// <summary>
        /// The time at which the ReservePlan expires.
        /// </summary>
        [JsonProperty("expires_on")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_on")]
#endif
        public long? ExpiresOn { get; set; }
    }
}
