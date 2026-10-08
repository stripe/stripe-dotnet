// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProviderServiceDetailPricingComponentOption : StripeEntity<ProviderServiceDetailPricingComponentOption>
    {
        /// <summary>
        /// Whether this option applies when no parent-service-specific option matches.
        /// </summary>
        [JsonProperty("is_default")]
        [STJS.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Pricing details for this option, set when <c>type</c> is <c>paid</c>.
        /// </summary>
        [JsonProperty("paid")]
        [STJS.JsonPropertyName("paid")]
        public ProviderServiceDetailPricingComponentOptionPaid Paid { get; set; }

        /// <summary>
        /// Identifiers of active parent services for which this option applies.
        /// </summary>
        [JsonProperty("parent_services")]
        [STJS.JsonPropertyName("parent_services")]
        public List<string> ParentServices { get; set; }

        /// <summary>
        /// Whether the component is free or paid when this option applies.
        /// One of: <c>free</c>, or <c>paid</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
