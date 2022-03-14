// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ConfigurationFeaturesSubscriptionCancelCancellationReason : StripeEntity<ConfigurationFeaturesSubscriptionCancelCancellationReason>
    {
        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Which cancellation reasons will be given as options to the customer.
        /// </summary>
        [JsonProperty("options")]
        public List<string> Options { get; set; }
    }
}
