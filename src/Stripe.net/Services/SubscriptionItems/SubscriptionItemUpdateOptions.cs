namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionItemUpdateOptions : SubscriptionItemSharedOptions
    {
        /// <summary>
        /// A set of key/value pairs that you can attach to a subscription object. It can be useful for storing additional information about the subscription in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Use <c>error_if_incomplete</c> if you want Stripe to return an HTTP 402 status code if
        /// the invoice caused by the update cannot be paid. Otherwise use <c>allow_incomplete</c>.
        /// </summary>
        [JsonProperty("payment_behavior")]
        public string PaymentBehavior { get; set; }
    }
}
