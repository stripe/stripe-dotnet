// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A claimable sandbox is a Stripe sandbox that a user can claim into a new or existing
    /// Stripe account through an onboarding link. You can prefill it with an email address,
    /// sandbox name, and country. Claimable sandboxes have 60 days to be claimed. After this
    /// expiration time has passed, if the sandbox is not claimed, it will be deleted.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ClaimableSandbox : StripeEntity<ClaimableSandbox>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the claimable sandbox.
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
        /// The distribution channel used to pre-install your Stripe App on the claimable sandbox.
        /// Use <c>testing</c> to install your app's external test version or <c>public</c> to
        /// install its published version.
        /// One of: <c>public</c>, or <c>testing</c>.
        /// </summary>
        [JsonProperty("channel")]
        [STJS.JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// Time at which the sandbox was claimed. Set when the status is <c>claimed</c> or
        /// <c>live</c>. Represented as an RFC 3339 timestamp in UTC with millisecond precision, for
        /// example <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("claimed_at")]
        [STJS.JsonPropertyName("claimed_at")]
        public DateTime? ClaimedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the sandbox was created. Represented as an RFC 3339 timestamp in UTC with
        /// millisecond precision, for example <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the unclaimed sandbox expires. Null when the status is <c>claimed</c> or
        /// <c>live</c>. Represented as an RFC 3339 timestamp in UTC with millisecond precision, for
        /// example <c>2022-09-18T13:22:18.123Z</c>.
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
        /// Details about the onboarding link. Null when the sandbox status is <c>live</c> or
        /// <c>expired</c>.
        /// </summary>
        [JsonProperty("onboarding_link_details")]
        [STJS.JsonPropertyName("onboarding_link_details")]
        public ClaimableSandboxOnboardingLinkDetails OnboardingLinkDetails { get; set; }

        /// <summary>
        /// Details about the live mode owner account of the sandbox. This will be null until the
        /// sandbox is claimed.
        /// </summary>
        [JsonProperty("owner_details")]
        [STJS.JsonPropertyName("owner_details")]
        public ClaimableSandboxOwnerDetails OwnerDetails { get; set; }

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
        /// Status of the sandbox.
        /// One of: <c>claimed</c>, <c>expired</c>, <c>live</c>, or <c>unclaimed</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
