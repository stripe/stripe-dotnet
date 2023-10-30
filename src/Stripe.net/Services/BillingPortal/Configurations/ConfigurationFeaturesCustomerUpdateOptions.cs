// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ConfigurationFeaturesCustomerUpdateOptions : INestedOptions
    {
        /// <summary>
        /// The types of customer updates that are supported. When empty, customers are not
        /// updateable.
        /// One of: <c>address</c>, <c>email</c>, <c>name</c>, <c>phone</c>, <c>shipping</c>, or
        /// <c>tax_id</c>.
        /// </summary>
        [JsonProperty("allowed_updates")]
        public List<string> AllowedUpdates { get; set; }

        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
