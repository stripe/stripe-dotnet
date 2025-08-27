// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.PricingPlans
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ComponentCreateServiceActionOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The ID of the service action.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }
    }
}
