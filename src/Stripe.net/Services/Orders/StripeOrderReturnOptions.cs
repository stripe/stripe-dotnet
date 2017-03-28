using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeOrderReturnOptions
    {
        /// <summary>
        /// Gets or sets a list of items to return.
        /// </summary>
        [JsonProperty("items")]
        public List<StripeOrderItemBase> StripeOrderItems { get; set; }
    }
}
