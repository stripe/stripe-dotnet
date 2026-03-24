// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountListOptions : V2.ListOptions
    {
        /// <summary>
        /// Additional fields to include in the response.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// The status of the FinancialAccount to filter by. By default, closed FinancialAccounts
        /// are not returned.
        /// One of: <c>closed</c>, <c>open</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Filter for FinancialAccount <c>type</c>. By default, FinancialAccounts of any
        /// <c>type</c> are returned.
        /// One of: <c>accrued_fees</c>, <c>payments</c>, or <c>storage</c>.
        /// </summary>
        [JsonProperty("types")]
        [STJS.JsonPropertyName("types")]
        public List<string> Types { get; set; }
    }
}
