// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingLineActionUpdatePricingPriceDetailsPricingOverrideActionOptions : INestedOptions
    {
        /// <summary>
        /// Parameters for adding a pricing line override.
        /// </summary>
        [JsonProperty("add")]
        [STJS.JsonPropertyName("add")]
        public ContractUpdatePricingLineActionUpdatePricingPriceDetailsPricingOverrideActionAddOptions Add { get; set; }

        /// <summary>
        /// Parameters for removing a pricing line override.
        /// </summary>
        [JsonProperty("remove")]
        [STJS.JsonPropertyName("remove")]
        public ContractUpdatePricingLineActionUpdatePricingPriceDetailsPricingOverrideActionRemoveOptions Remove { get; set; }

        /// <summary>
        /// The type of pricing line override action.
        /// One of: <c>add</c>, <c>remove</c>, or <c>update</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Parameters for updating a pricing line override.
        /// </summary>
        [JsonProperty("update")]
        [STJS.JsonPropertyName("update")]
        public ContractUpdatePricingLineActionUpdatePricingPriceDetailsPricingOverrideActionUpdateOptions Update { get; set; }
    }
}
