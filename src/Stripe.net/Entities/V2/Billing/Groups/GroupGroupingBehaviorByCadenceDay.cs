// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GroupGroupingBehaviorByCadenceDay : StripeEntity<GroupGroupingBehaviorByCadenceDay>
    {
        /// <summary>
        /// The time at which the daily grouping interval begins.
        /// </summary>
        [JsonProperty("time")]
        [STJS.JsonPropertyName("time")]
        public GroupGroupingBehaviorByCadenceDayTime Time { get; set; }
    }
}
