// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentBillingGroupDataGroupingBehaviorByCadenceDay : StripeEntity<IntentBillingGroupDataGroupingBehaviorByCadenceDay>
    {
        /// <summary>
        /// The time at which the daily grouping interval begins.
        /// </summary>
        [JsonProperty("time")]
        [STJS.JsonPropertyName("time")]
        public IntentBillingGroupDataGroupingBehaviorByCadenceDayTime Time { get; set; }
    }
}
