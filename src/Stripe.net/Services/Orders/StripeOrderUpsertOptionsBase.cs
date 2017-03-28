using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public abstract class StripeOrderUpsertOptionsBase
    {
        /// <summary>
        /// Gets or sets a coupon code that represents a discount to be applied to this order. Must be one-time duration and in same currency as the order.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// Gets or sets a set of key/value pairs that you can attach to an order object. It can be useful for storing additional information about the order in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
