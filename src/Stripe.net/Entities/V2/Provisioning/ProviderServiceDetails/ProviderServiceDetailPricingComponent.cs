// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProviderServiceDetailPricingComponent : StripeEntity<ProviderServiceDetailPricingComponent>
    {
        /// <summary>
        /// Pricing options selected according to the resource's active parent services.
        /// </summary>
        [JsonProperty("options")]
        [STJS.JsonPropertyName("options")]
        public List<ProviderServiceDetailPricingComponentOption> Options { get; set; }
    }
}
