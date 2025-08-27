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
        /// Keys that can be used to set up an integration for this sandbox and operate on the
        /// account.
        /// </summary>
        [JsonProperty("api_keys")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("api_keys")]
#endif
        public ClaimableSandboxApiKeys ApiKeys { get; set; }

        /// <summary>
        /// URL for user to claim sandbox into their existing Stripe account.
        /// </summary>
        [JsonProperty("claim_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("claim_url")]
#endif
        public string ClaimUrl { get; set; }

        /// <summary>
        /// When the sandbox is created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
    }
}
