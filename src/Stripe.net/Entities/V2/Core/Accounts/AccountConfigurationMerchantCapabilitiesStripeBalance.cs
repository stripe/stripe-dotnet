// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMerchantCapabilitiesStripeBalance : StripeEntity<AccountConfigurationMerchantCapabilitiesStripeBalance>
    {
        /// <summary>
        /// Enables this Account to complete payouts from their Stripe Balance (/v1/balance).
        /// </summary>
        [JsonProperty("payouts")]
        [STJS.JsonPropertyName("payouts")]
        public AccountConfigurationMerchantCapabilitiesStripeBalancePayouts Payouts { get; set; }
    }
}
