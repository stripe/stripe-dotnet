// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateContractLineOverrideStartsAtOptions : INestedOptions
    {
        /// <summary>
        /// The timestamp when the item starts.
        /// </summary>
        [JsonProperty("timestamp")]
        [STJS.JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }
    }
}
