// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProviderServiceDetailPricingPaidPricing : StripeEntity<ProviderServiceDetailPricingPaidPricing>
    {
        [JsonProperty("configuration")]
        [STJS.JsonPropertyName("configuration")]
        public Dictionary<string, object> Configuration { get; set; }

        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("freeform")]
        [STJS.JsonPropertyName("freeform")]
        public string Freeform { get; set; }

        [JsonProperty("is_default")]
        [STJS.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// One of: <c>free</c>, or <c>freeform</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
