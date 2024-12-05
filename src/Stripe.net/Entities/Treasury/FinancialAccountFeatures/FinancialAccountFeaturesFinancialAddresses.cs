// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class FinancialAccountFeaturesFinancialAddresses : StripeEntity<FinancialAccountFeaturesFinancialAddresses>
    {
        /// <summary>
        /// Toggle settings for enabling/disabling the ABA address feature.
        /// </summary>
        [JsonProperty("aba")]
        public FinancialAccountFeaturesFinancialAddressesAba Aba { get; set; }
    }
}
