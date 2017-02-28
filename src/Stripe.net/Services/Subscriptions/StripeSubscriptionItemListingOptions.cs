using Newtonsoft.Json;
using System;

namespace Stripe
{
    public class StripeSubscriptionItemListingOptions
    {        
        [JsonProperty("ending_before")]
        public DateTime? EndingBefore { get; set; }        
        
        /// <remarks>
        /// default is 10
        /// </remarks>
        [JsonProperty("starting_after")]
        public int? Limit { get; set; }

        [JsonProperty("limit")]
        public DateTime? StartingAfter { get; set; }
    }
}
