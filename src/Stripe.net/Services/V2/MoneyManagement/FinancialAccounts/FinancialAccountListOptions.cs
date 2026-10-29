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
        /// Return FinancialAccounts whose <c>status</c> matches any of the provided values. If
        /// omitted, closed FinancialAccounts are not returned.
        /// One of: <c>closed</c>, <c>open</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("statuses")]
        [STJS.JsonPropertyName("statuses")]
        public List<string> Statuses { get; set; }
    }
}
