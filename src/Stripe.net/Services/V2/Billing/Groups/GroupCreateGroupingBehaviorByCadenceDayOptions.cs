// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GroupCreateGroupingBehaviorByCadenceDayOptions : INestedOptions
    {
        /// <summary>
        /// The time at which the daily grouping interval begins.
        /// </summary>
        [JsonProperty("time")]
        [STJS.JsonPropertyName("time")]
        public GroupCreateGroupingBehaviorByCadenceDayTimeOptions Time { get; set; }
    }
}
