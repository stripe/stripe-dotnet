// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter by customer ID.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Additional fields to include in the response.
        /// One of: <c>billing_settings</c>, <c>one_time_fees</c>, <c>pricing_lines</c>, or
        /// <c>pricing_overrides</c>.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }
    }
}
