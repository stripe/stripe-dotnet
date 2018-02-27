using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSubscriptionItemUpdateOption : INestedOptions
    {
        /// <summary>
        /// SubscriptionItem to update.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Delete all usage for a given subscription item. Only allowed when <c>deleted</c> is set to true and the current plan’s <c>usage_type</c> is metered.
        /// </summary>
        [JsonProperty("clear_usage")]
        public bool? ClearUsage { get; set; }

        /// <summary>
        /// Delete the specified item if set to true.
        /// </summary>
        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to an object. It can be useful for storing additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Plan ID for this item.
        /// </summary>
        [JsonProperty("plan")]
        public string PlanId { get; set; }

        /// <summary>
        /// Quantity for this item.
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }
}
