// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCancelTermOptions : INestedOptions
    {
        /// <summary>
        /// Falls back to the contract cancellation's top-level proration behavior.
        /// One of: <c>none</c>, or <c>prorated</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("proration_behavior")]
        [STJS.JsonPropertyName("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// Select a term by ID or its unique lookup key.
        /// </summary>
        [JsonProperty("term")]
        [STJS.JsonPropertyName("term")]
        public ContractCancelTermTermOptions Term { get; set; }
    }
}
