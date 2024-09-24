namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use FinancialAccountFeaturesFinancialAddressesOptions instead.")]
    public class FinancialAccountFinancialAddressesOptions : INestedOptions
    {
        /// <summary>
        /// Adds an ABA FinancialAddress to the FinancialAccount.
        /// </summary>
        [JsonProperty("aba")]
        public FinancialAccountFinancialAddressesAbaOptions Aba { get; set; }
    }
}
