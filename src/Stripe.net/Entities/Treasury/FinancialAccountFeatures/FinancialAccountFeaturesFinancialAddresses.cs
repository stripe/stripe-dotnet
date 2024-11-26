// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountFeaturesFinancialAddresses : StripeEntity<FinancialAccountFeaturesFinancialAddresses>
    {
        /// <summary>
        /// Toggle settings for enabling/disabling the ABA address feature.
        /// </summary>
        [JsonProperty("aba")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("aba")]
#endif
        public FinancialAccountFeaturesFinancialAddressesAba Aba { get; set; }
    }
}
