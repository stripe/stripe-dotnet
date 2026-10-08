// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedCreditsOnrampCryptoWalletsMxnProtectionsOptions : INestedOptions
    {
        /// <summary>
        /// Parameter to request psp_migration protection.
        /// </summary>
        [JsonProperty("psp_migration")]
        [STJS.JsonPropertyName("psp_migration")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesReceivedCreditsOnrampCryptoWalletsMxnProtectionsPspMigrationOptions PspMigration { get; set; }
    }
}
