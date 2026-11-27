// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.TestHelpers
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAddressDebitNetworkDetailsOptions : INestedOptions
    {
        /// <summary>
        /// ACH-specific details for the simulated debit.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public FinancialAddressDebitNetworkDetailsAchOptions Ach { get; set; }
    }
}
