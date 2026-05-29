// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateContractLineOverrideServiceActionOptions : INestedOptions
    {
        /// <summary>
        /// Parameters for adding a new service action.
        /// </summary>
        [JsonProperty("add")]
        [STJS.JsonPropertyName("add")]
        public ContractCreateContractLineOverrideServiceActionAddOptions Add { get; set; }

        /// <summary>
        /// Parameters for replacing an existing service action.
        /// </summary>
        [JsonProperty("replace")]
        [STJS.JsonPropertyName("replace")]
        public ContractCreateContractLineOverrideServiceActionReplaceOptions Replace { get; set; }

        /// <summary>
        /// The type of service action override.
        /// One of: <c>add</c>, or <c>replace</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
