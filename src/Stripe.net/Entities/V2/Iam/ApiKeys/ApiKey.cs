// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An API key is used to authenticate API requests.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ApiKey : StripeEntity<ApiKey>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier of the API key.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Timestamp when the API key was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp when the API key expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [STJS.JsonPropertyName("expires_at")]
        public DateTime? ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// List of IP addresses allowed to use this API key. Addresses use IPv4 protocol, and may
        /// be a CIDR range (e.g., [100.10.38.255, 100.10.38.0/24]).
        /// </summary>
        [JsonProperty("ip_allowlist")]
        [STJS.JsonPropertyName("ip_allowlist")]
        public List<string> IpAllowlist { get; set; }

        /// <summary>
        /// Timestamp when the API key was last used.
        /// </summary>
        [JsonProperty("last_used")]
        [STJS.JsonPropertyName("last_used")]
        public DateTime? LastUsed { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Account that manages this API key (for keys managed by platforms).
        /// </summary>
        [JsonProperty("managed_by")]
        [STJS.JsonPropertyName("managed_by")]
        public ApiKeyManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Name of the API key.
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
        /// Token set for a publishable key.
        /// </summary>
        [JsonProperty("publishable_key")]
        [STJS.JsonPropertyName("publishable_key")]
        public ApiKeyPublishableKey PublishableKey { get; set; }

        /// <summary>
        /// Token set for a secret key.
        /// </summary>
        [JsonProperty("secret_key")]
        [STJS.JsonPropertyName("secret_key")]
        public ApiKeySecretKey SecretKey { get; set; }

        /// <summary>
        /// Current status of the API key (e.g., active, expired).
        /// One of: <c>active</c>, or <c>expired</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of the API key.
        /// One of: <c>publishable_key</c>, or <c>secret_key</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
