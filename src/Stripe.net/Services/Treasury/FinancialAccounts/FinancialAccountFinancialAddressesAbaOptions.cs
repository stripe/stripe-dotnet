namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use FinancialAccountFeaturesFinancialAddressesAbaOptions instead.")]
    public class FinancialAccountFinancialAddressesAbaOptions : INestedOptions
    {
        /// <summary>
        /// Whether the FinancialAccount should have the Feature.
        /// </summary>
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
