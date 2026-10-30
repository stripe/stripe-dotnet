// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateActionOptions : INestedOptions
    {
        /// <summary>
        /// Prepend a term, preserving relative order among additions in this request.
        /// </summary>
        [JsonProperty("add_term")]
        [STJS.JsonPropertyName("add_term")]
        public ContractUpdateActionAddTermOptions AddTerm { get; set; }

        /// <summary>
        /// Remove a term that has not started.
        /// </summary>
        [JsonProperty("remove_term")]
        [STJS.JsonPropertyName("remove_term")]
        public ContractUpdateActionRemoveTermOptions RemoveTerm { get; set; }

        /// <summary>
        /// The action type. Exactly one matching payload is required.
        /// One of: <c>add_term</c>, <c>remove_term</c>, or <c>update_term</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Edit a term without changing its display position.
        /// </summary>
        [JsonProperty("update_term")]
        [STJS.JsonPropertyName("update_term")]
        public ContractUpdateActionUpdateTermOptions UpdateTerm { get; set; }
    }
}
