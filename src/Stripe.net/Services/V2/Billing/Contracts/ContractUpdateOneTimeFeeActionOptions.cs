// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateOneTimeFeeActionOptions : INestedOptions
    {
        /// <summary>
        /// Parameters for adding a one-time fee.
        /// </summary>
        [JsonProperty("add")]
        [STJS.JsonPropertyName("add")]
        public ContractUpdateOneTimeFeeActionAddOptions Add { get; set; }

        /// <summary>
        /// Parameters for removing a one-time fee.
        /// </summary>
        [JsonProperty("remove")]
        [STJS.JsonPropertyName("remove")]
        public ContractUpdateOneTimeFeeActionRemoveOptions Remove { get; set; }

        /// <summary>
        /// The type of one-time fee action.
        /// One of: <c>add</c>, <c>remove</c>, or <c>update</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Parameters for updating a one-time fee.
        /// </summary>
        [JsonProperty("update")]
        [STJS.JsonPropertyName("update")]
        public ContractUpdateOneTimeFeeActionUpdateOptions Update { get; set; }
    }
}
