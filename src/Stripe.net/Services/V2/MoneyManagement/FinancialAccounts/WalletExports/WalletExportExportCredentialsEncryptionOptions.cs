// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.FinancialAccounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class WalletExportExportCredentialsEncryptionOptions : INestedOptions
    {
        /// <summary>
        /// Base64url-encoded raw P-256 recipient public key. Stripe does not persist this key
        /// material.
        /// </summary>
        [JsonProperty("recipient_public_key")]
        [STJS.JsonPropertyName("recipient_public_key")]
        public string RecipientPublicKey { get; set; }

        /// <summary>
        /// Encryption scheme for the response. HPKE uses BASE mode, DHKEM_P256_HKDF_SHA256,
        /// HKDF_SHA256, and CHACHA20_POLY1305.
        /// One of: <c>hpke</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
