// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// An API key.
    /// </summary>
    public class ApiKey : StripeEntity<ApiKey>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier of the API key.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Timestamp when the API key was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Timestamp when the API key expires.
        /// </summary>
        [JsonProperty("expires_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif
        public DateTime? ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// List of IP addresses allowed to use this API key.
        /// </summary>
        [JsonProperty("ip_allowlist")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ip_allowlist")]
#endif
        public List<string> IpAllowlist { get; set; }

        /// <summary>
        /// Timestamp when the API key was last used.
        /// </summary>
        [JsonProperty("last_used")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_used")]
#endif
        public DateTime? LastUsed { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Account that manages this API key (for keys managed by platforms).
        /// </summary>
        [JsonProperty("managed_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("managed_by")]
#endif
        public string ManagedBy { get; set; }

        /// <summary>
        /// Name of the API key.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Note or description for the API key.
        /// </summary>
        [JsonProperty("note")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("note")]
#endif
        public string Note { get; set; }

        /// <summary>
        /// Token set for a publishable key.
        /// </summary>
        [JsonProperty("publishable_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("publishable_key")]
#endif
        public ApiKeyPublishableKey PublishableKey { get; set; }

        /// <summary>
        /// Token set for a secret key.
        /// </summary>
        [JsonProperty("secret_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("secret_key")]
#endif
        public ApiKeySecretKey SecretKey { get; set; }

        /// <summary>
        /// Current status of the API key (e.g., active, expired).
        /// One of: <c>active</c>, or <c>expired</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Type of the API key.
        /// One of: <c>publishable_key</c>, or <c>secret_key</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
