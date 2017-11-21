using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public abstract class SubscriptionItemSharedOptions : StripeBaseOptions
    {
        /// <summary>
        /// REQUIRED: The identifier of the plan to add to the subscription.
        /// </summary>
        [JsonProperty("plan")]
        public string PlanId { get; set; }

        /// <summary>
        /// Flag indicating whether to prorate switching plans during a billing cycle.
        /// </summary>
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        /// <summary>
        /// If set, the proration will be calculated as though the subscription was updated at the given time. This can be used to apply the same proration that was previewed with the upcoming invoice endpoint.
        /// </summary>
        public DateTime? ProrationDate { get; set; }

        [JsonProperty("proration_date")]
        internal long? ProrationDateInternal
        {
            get
            {
                if (!ProrationDate.HasValue) return null;

                return ProrationDate.Value.ConvertDateTimeToEpoch();
            }
        }

        /// <summary>
        /// The quantity you’d like to apply to the subscription item you’re creating.
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }
}