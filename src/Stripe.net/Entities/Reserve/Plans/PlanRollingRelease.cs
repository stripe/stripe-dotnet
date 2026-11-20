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
        /// The number of days after a payment's <c>fulfillment_date</c> to reserve funds before
        /// releasing them. The hold releases at midnight UTC that many days after the fulfillment
        /// date. Charges without a <c>fulfillment_date</c> use <c>days_after_charge</c>.
        /// </summary>
        [JsonProperty("days_after_fulfillment")]
        [STJS.JsonPropertyName("days_after_fulfillment")]
        public long? DaysAfterFulfillment { get; set; }

        /// <summary>
        /// The time at which the ReservePlan expires.
        /// </summary>
        [JsonProperty("expires_on")]
        [STJS.JsonPropertyName("expires_on")]
        public long? ExpiresOn { get; set; }
    }
}
