// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountListOptions : V2.ListOptions
    {
        /// <summary>
        /// The status of the FinancialAccount to filter by. By default, closed FinancialAccounts
        /// are not returned.
        /// One of: <c>closed</c>, <c>open</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
