namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class SubscriptionItemCreateOptions : SubscriptionItemSharedOptions, ISupportMetadata
    {
        /// <summary>
        /// REQUIRED: The identifier of the subscription to modify.
        /// </summary>
        [FormProperty("subscription")]
        public string SubscriptionId { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
