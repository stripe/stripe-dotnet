// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A claimable sandbox represents a Stripe sandbox that is anonymous. When it is created,
    /// it can be prefilled with specific metadata, such as email, name, or country. Claimable
    /// sandboxes can be claimed through a URL. When a user claims a sandbox through this URL,
    /// it will prompt them to create a new Stripe account. Or, it will allow them to claim this
    /// sandbox in their existing Stripe account. Claimable sandboxes have 60 days to be
    /// claimed. After this expiration time has passed, if the sandbox is not claimed, it will
    /// be deleted.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ClaimableSandbox : StripeEntity<ClaimableSandbox>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the Claimable sandbox.
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
        /// URL for user to claim sandbox into their existing Stripe account. The value will be null
        /// if the sandbox status is <c>claimed</c> or <c>expired</c>.
        /// </summary>
        [JsonProperty("claim_url")]
        [STJS.JsonPropertyName("claim_url")]
        public string ClaimUrl { get; set; }

        /// <summary>
        /// The timestamp the sandbox was claimed. The value will be null if the sandbox status is
        /// not <c>claimed</c>.
        /// </summary>
        [JsonProperty("claimed_at")]
        [STJS.JsonPropertyName("claimed_at")]
        public DateTime? ClaimedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// When the sandbox is created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The timestamp the sandbox will expire. The value will be null if the sandbox is
        /// <c>claimed</c>.
        /// </summary>
        [JsonProperty("expires_at")]
        [STJS.JsonPropertyName("expires_at")]
        public DateTime? ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Values prefilled during the creation of the sandbox. When a user claims the sandbox,
        /// they will be able to update these values.
        /// </summary>
        [JsonProperty("prefill")]
        [STJS.JsonPropertyName("prefill")]
        public ClaimableSandboxPrefill Prefill { get; set; }

        /// <summary>
        /// Data about the Stripe sandbox object.
        /// </summary>
        [JsonProperty("sandbox_details")]
        [STJS.JsonPropertyName("sandbox_details")]
        public ClaimableSandboxSandboxDetails SandboxDetails { get; set; }

        /// <summary>
        /// Status of the sandbox. One of <c>unclaimed</c>, <c>expired</c>, <c>claimed</c>.
        /// One of: <c>claimed</c>, <c>expired</c>, or <c>unclaimed</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
