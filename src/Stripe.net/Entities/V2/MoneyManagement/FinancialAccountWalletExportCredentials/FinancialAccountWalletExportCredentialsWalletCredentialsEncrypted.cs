// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountWalletExportCredentialsWalletCredentialsEncrypted : StripeEntity<FinancialAccountWalletExportCredentialsWalletCredentialsEncrypted>
    {
        /// <summary>
        /// Base64url-encoded encrypted wallet credentials. Stripe does not persist this response.
        /// </summary>
        [JsonProperty("ciphertext")]
        [STJS.JsonPropertyName("ciphertext")]
        public string Ciphertext { get; set; }

        /// <summary>
        /// Base64url-encoded HPKE encapsulated key.
        /// </summary>
        [JsonProperty("encapsulated_key")]
        [STJS.JsonPropertyName("encapsulated_key")]
        public string EncapsulatedKey { get; set; }

        /// <summary>
        /// Encryption scheme used for these credentials.
        /// One of: <c>hpke</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
