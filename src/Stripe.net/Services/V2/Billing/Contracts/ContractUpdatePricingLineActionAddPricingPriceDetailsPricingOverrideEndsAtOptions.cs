// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingLineActionAddPricingPriceDetailsPricingOverrideEndsAtOptions : INestedOptions
    {
        /// <summary>
        /// The timestamp when the item ends. Required if <c>type</c> is <c>timestamp</c>.
        /// </summary>
        [JsonProperty("timestamp")]
        [STJS.JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The type of the ends_at.
        /// One of: <c>contract_end</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
