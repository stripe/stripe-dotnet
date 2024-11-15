// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationFeaturesCustomerUpdateOptions : INestedOptions
    {
        /// <summary>
        /// The types of customer updates that are supported. When empty, customers are not
        /// updateable.
        /// One of: <c>address</c>, <c>email</c>, <c>name</c>, <c>phone</c>, <c>shipping</c>, or
        /// <c>tax_id</c>.
        /// </summary>
        [JsonProperty("allowed_updates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allowed_updates")]
#endif

        public List<string> AllowedUpdates { get; set; }

        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif

        public bool? Enabled { get; set; }
    }
}
