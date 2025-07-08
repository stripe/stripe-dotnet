// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountListOptions : V2.ListOptions
    {
        /// <summary>
        /// The status of the FinancialAccount to filter by. By default, closed FinancialAccounts
        /// are not returned.
        /// One of: <c>closed</c>, <c>open</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
