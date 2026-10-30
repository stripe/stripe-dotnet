// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateActionRemoveTermOptions : INestedOptions
    {
        /// <summary>
        /// Select a term by ID or its unique lookup key.
        /// </summary>
        [JsonProperty("term")]
        [STJS.JsonPropertyName("term")]
        public ContractUpdateActionRemoveTermTermOptions Term { get; set; }
    }
}
