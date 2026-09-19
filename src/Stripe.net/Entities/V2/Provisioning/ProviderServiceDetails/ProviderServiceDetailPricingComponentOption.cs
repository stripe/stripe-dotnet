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
        [JsonProperty("is_default")]
        [STJS.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        [JsonProperty("paid")]
        [STJS.JsonPropertyName("paid")]
        public ProviderServiceDetailPricingComponentOptionPaid Paid { get; set; }

        [JsonProperty("parent_services")]
        [STJS.JsonPropertyName("parent_services")]
        public List<string> ParentServices { get; set; }

        /// <summary>
        /// One of: <c>free</c>, or <c>paid</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
