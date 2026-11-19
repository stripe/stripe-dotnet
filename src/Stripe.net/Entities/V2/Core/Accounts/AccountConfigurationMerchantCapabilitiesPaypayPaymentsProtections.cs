// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMerchantCapabilitiesPaypayPaymentsProtections : StripeEntity<AccountConfigurationMerchantCapabilitiesPaypayPaymentsProtections>
    {
        /// <summary>
        /// Protection details for PSP migration.
        /// </summary>
        [JsonProperty("psp_migration")]
        [STJS.JsonPropertyName("psp_migration")]
        public AccountConfigurationMerchantCapabilitiesPaypayPaymentsProtectionsPspMigration PspMigration { get; set; }
    }
}
