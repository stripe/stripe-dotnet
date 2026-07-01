// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ApiKeyCreateOptions : BaseOptions
    {
        /// <summary>
        /// List of connect permissions for this API key.
        /// </summary>
        [JsonProperty("connect_permissions")]
        [STJS.JsonPropertyName("connect_permissions")]
        public List<string> ConnectPermissions { get; set; }

        /// <summary>
        /// Timestamp at which the key expires. If not provided, the key never expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [STJS.JsonPropertyName("expires_at")]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Name for the API key.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Note or description for the API key.
        /// </summary>
        [JsonProperty("note")]
        [STJS.JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// List of permissions for this API key.
        /// </summary>
        [JsonProperty("permissions")]
        [STJS.JsonPropertyName("permissions")]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Public key for encrypting the API key secret. This must a PEM-formatted RSA key suitable
        /// for encryption, &gt;= 2048 bits. A public key is required when creating secret keys.
        /// Publishable keys are not encrypted and a public key should not be included.
        /// </summary>
        [JsonProperty("public_key")]
        [STJS.JsonPropertyName("public_key")]
        public ApiKeyCreatePublicKeyOptions PublicKey { get; set; }

        /// <summary>
        /// Type of the API key to create (secret or publishable).
        /// One of: <c>publishable_key</c>, or <c>secret_key</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
