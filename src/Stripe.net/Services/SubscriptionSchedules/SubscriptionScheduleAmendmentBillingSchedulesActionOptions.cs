// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionScheduleAmendmentBillingSchedulesActionOptions : INestedOptions
    {
        /// <summary>
        /// Specify which subscription items the billing schedule applies to.
        /// </summary>
        [JsonProperty("applies_to")]
        [STJS.JsonPropertyName("applies_to")]
        public List<SubscriptionScheduleAmendmentBillingSchedulesActionAppliesToOptions> AppliesTo { get; set; }

        /// <summary>
        /// Select the action.
        /// One of: <c>remove</c>, or <c>set</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
