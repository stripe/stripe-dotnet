// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateBillingCycleAnchorOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for determining the billing cycle anchor by calendar fields.
        /// </summary>
        [JsonProperty("config")]
        [STJS.JsonPropertyName("config")]
        public ContractCreateBillingCycleAnchorConfigOptions Config { get; set; }

        /// <summary>
        /// A specific timestamp to use as the billing cycle anchor.
        /// </summary>
        [JsonProperty("timestamp")]
        [STJS.JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The type of billing cycle anchor.
        /// One of: <c>config</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
