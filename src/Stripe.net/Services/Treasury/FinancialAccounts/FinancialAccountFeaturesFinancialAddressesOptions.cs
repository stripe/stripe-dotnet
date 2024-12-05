// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class FinancialAccountFeaturesFinancialAddressesOptions : INestedOptions
    {
        /// <summary>
        /// Adds an ABA FinancialAddress to the FinancialAccount.
        /// </summary>
        [JsonProperty("aba")]
        public FinancialAccountFeaturesFinancialAddressesAbaOptions Aba { get; set; }
    }
}
