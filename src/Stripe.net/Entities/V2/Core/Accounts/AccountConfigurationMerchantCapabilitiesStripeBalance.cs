// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationMerchantCapabilitiesStripeBalance : StripeEntity<AccountConfigurationMerchantCapabilitiesStripeBalance>
    {
        /// <summary>
        /// Enables this Account to complete payouts from their Stripe Balance (/v1/balance).
        /// </summary>
        [JsonProperty("payouts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payouts")]
#endif
        public AccountConfigurationMerchantCapabilitiesStripeBalancePayouts Payouts { get; set; }
    }
}
