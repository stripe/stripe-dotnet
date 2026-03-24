// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PlanRollingRelease : StripeEntity<PlanRollingRelease>
    {
        /// <summary>
        /// The number of days to reserve funds before releasing.
        /// </summary>
        [JsonProperty("days_after_charge")]
        [STJS.JsonPropertyName("days_after_charge")]
        public long DaysAfterCharge { get; set; }

        /// <summary>
        /// The time at which the ReservePlan expires.
        /// </summary>
        [JsonProperty("expires_on")]
        [STJS.JsonPropertyName("expires_on")]
        public long? ExpiresOn { get; set; }
    }
}
