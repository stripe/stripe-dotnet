// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingOverrideActionUpdateOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The updated end time for the pricing override.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractUpdatePricingOverrideActionUpdateEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// The ID of the pricing override.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The updated start time for the pricing override.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractUpdatePricingOverrideActionUpdateStartsAtOptions StartsAt { get; set; }
    }
}
