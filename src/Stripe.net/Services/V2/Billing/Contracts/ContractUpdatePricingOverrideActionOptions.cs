// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingOverrideActionOptions : INestedOptions
    {
        /// <summary>
        /// Add a pricing override.
        /// </summary>
        [JsonProperty("add")]
        [STJS.JsonPropertyName("add")]
        public ContractUpdatePricingOverrideActionAddOptions Add { get; set; }

        /// <summary>
        /// Remove a pricing override.
        /// </summary>
        [JsonProperty("remove")]
        [STJS.JsonPropertyName("remove")]
        public ContractUpdatePricingOverrideActionRemoveOptions Remove { get; set; }

        /// <summary>
        /// The type of pricing override action.
        /// One of: <c>add</c>, <c>remove</c>, or <c>update</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Update a pricing override.
        /// </summary>
        [JsonProperty("update")]
        [STJS.JsonPropertyName("update")]
        public ContractUpdatePricingOverrideActionUpdateOptions Update { get; set; }
    }
}
