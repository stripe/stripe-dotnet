// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanComponentRateCard : StripeEntity<PricingPlanComponentRateCard>, IHasId
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
