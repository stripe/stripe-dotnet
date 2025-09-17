// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A claimable sandbox represents a Stripe sandbox that is anonymous. When it is created,
    /// it can be prefilled with specific metadata, such as email, name, or country. Claimable
    /// sandboxes can be claimed through a URL. When a user claims a sandbox through this URL,
    /// it will prompt them to create a new Stripe account. Or, it will allow them to claim this
    /// sandbox in their existing Stripe account. Claimable sandboxes have 60 days to be
    /// claimed. After this expiration time has passed, if the sandbox is not claimed, it will
    /// be deleted.
    /// </summary>
    public class ClaimableSandbox : StripeEntity<ClaimableSandbox>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the Claimable sandbox.
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
        /// URL for user to claim sandbox into their existing Stripe account. The value will be null
        /// if the sandbox status is <c>claimed</c> or <c>expired</c>.
        /// </summary>
        [JsonProperty("claim_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("claim_url")]
#endif
        public string ClaimUrl { get; set; }

        /// <summary>
        /// The timestamp the sandbox was claimed. The value will be null if the sandbox status is
        /// not <c>claimed</c>.
        /// </summary>
        [JsonProperty("claimed_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("claimed_at")]
#endif
        public DateTime? ClaimedAt { get; set; }

        /// <summary>
        /// When the sandbox is created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The timestamp the sandbox will expire. The value will be null if the sandbox is
        /// <c>claimed</c>.
        /// </summary>
        [JsonProperty("expires_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif
        public DateTime? ExpiresAt { get; set; }

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
        /// Values prefilled during the creation of the sandbox.
        /// </summary>
        [JsonProperty("prefill")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prefill")]
#endif
        public ClaimableSandboxPrefill Prefill { get; set; }

        /// <summary>
        /// Data about the Stripe sandbox object.
        /// </summary>
        [JsonProperty("sandbox_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sandbox_details")]
#endif
        public ClaimableSandboxSandboxDetails SandboxDetails { get; set; }

        /// <summary>
        /// Status of the sandbox. One of <c>unclaimed</c>, <c>expired</c>, <c>claimed</c>.
        /// One of: <c>claimed</c>, <c>expired</c>, or <c>unclaimed</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
