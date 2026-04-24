// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsApiKey : StripeEntity<ActivityLogDetailsApiKey>, IHasId
    {
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
        /// Unique identifier of the API key.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// List of IP addresses allowed to use this API key.
        /// </summary>
        [JsonProperty("ip_allowlist")]
        [STJS.JsonPropertyName("ip_allowlist")]
        public List<string> IpAllowlist { get; set; }

        /// <summary>
        /// Information about the entity managing this API key.
        /// </summary>
        [JsonProperty("managed_by")]
        [STJS.JsonPropertyName("managed_by")]
        public ActivityLogDetailsApiKeyManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Name of the API key.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Unique identifier of the new API key, set when this key was rotated.
        /// </summary>
        [JsonProperty("new_key")]
        [STJS.JsonPropertyName("new_key")]
        public string NewKey { get; set; }

        /// <summary>
        /// Note or description for the API key.
        /// </summary>
        [JsonProperty("note")]
        [STJS.JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// Type of the API key.
        /// One of: <c>publishable_key</c>, or <c>secret_key</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
