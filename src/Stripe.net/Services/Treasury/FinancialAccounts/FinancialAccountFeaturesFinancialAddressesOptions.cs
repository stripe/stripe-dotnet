// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountFeaturesFinancialAddressesOptions : INestedOptions
    {
        /// <summary>
        /// Adds an ABA FinancialAddress to the FinancialAccount.
        /// </summary>
        [JsonProperty("aba")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("aba")]
#endif
        public FinancialAccountFeaturesFinancialAddressesAbaOptions Aba { get; set; }
    }
}
