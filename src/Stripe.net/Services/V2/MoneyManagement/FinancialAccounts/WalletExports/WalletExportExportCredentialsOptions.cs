// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.FinancialAccounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class WalletExportExportCredentialsOptions : BaseOptions
    {
        /// <summary>
        /// Encryption parameters for the exported credentials.
        /// </summary>
        [JsonProperty("encryption")]
        [STJS.JsonPropertyName("encryption")]
        public WalletExportExportCredentialsEncryptionOptions Encryption { get; set; }
    }
}
