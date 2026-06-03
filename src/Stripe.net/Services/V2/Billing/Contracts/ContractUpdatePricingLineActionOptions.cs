// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingLineActionOptions : INestedOptions
    {
        /// <summary>
        /// Parameters for adding a pricing line.
        /// </summary>
        [JsonProperty("add")]
        [STJS.JsonPropertyName("add")]
        public ContractUpdatePricingLineActionAddOptions Add { get; set; }

        /// <summary>
        /// Parameters for removing a pricing line.
        /// </summary>
        [JsonProperty("remove")]
        [STJS.JsonPropertyName("remove")]
        public ContractUpdatePricingLineActionRemoveOptions Remove { get; set; }

        /// <summary>
        /// The type of pricing line action.
        /// One of: <c>add</c>, <c>remove</c>, or <c>update</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Parameters for updating a pricing line.
        /// </summary>
        [JsonProperty("update")]
        [STJS.JsonPropertyName("update")]
        public ContractUpdatePricingLineActionUpdateOptions Update { get; set; }
    }
}
