// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ClaimableSandboxSandboxDetailsApiKeysPublishable : StripeEntity<ClaimableSandboxSandboxDetailsApiKeysPublishable>, IHasId
    {
        /// <summary>
        /// Time at which the API key was created. Represented as an RFC 3339 timestamp in UTC with
        /// millisecond precision, for example <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the API key expires. Represented as an RFC 3339 timestamp in UTC with
        /// millisecond precision, for example <c>2022-09-18T13:22:18.123Z</c>.
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
        /// Token for the publishable key. Present only in the create response; null in subsequent
        /// retrieve responses.
        /// </summary>
        [JsonProperty("publishable_key")]
        [STJS.JsonPropertyName("publishable_key")]
        public ClaimableSandboxSandboxDetailsApiKeysPublishablePublishableKey PublishableKey { get; set; }

        /// <summary>
        /// Current status of the API key.
        /// One of: <c>active</c>, or <c>expired</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of the API key.
        /// One of: <c>publishable_key</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
