// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.PricingPlans
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ComponentCreateRateCardOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The ID of the Rate Card.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the Rate Card Version. If not specified, defaults to 'latest'.
        /// </summary>
        [JsonProperty("version")]
        [STJS.JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
