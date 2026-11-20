// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.TestHelpers
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAddressDebitNetworkDetailsAchOptions : INestedOptions
    {
        /// <summary>
        /// The ACH company ID of the originator of the simulated debit. Must contain exactly 10
        /// alphanumeric characters. Sent to the network in uppercase.
        /// </summary>
        [JsonProperty("originator_company_id")]
        [STJS.JsonPropertyName("originator_company_id")]
        public string OriginatorCompanyId { get; set; }
    }
}
