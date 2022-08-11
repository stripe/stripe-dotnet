// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Secret Store is an API that allows Stripe Apps developers to securely persist secrets
    /// for use by UI Extensions and app backends.
    ///
    /// The primary resource in Secret Store is a <c>secret</c>. Other apps can't view secrets
    /// created by an app. Additionally, secrets are scoped to provide further permission
    /// control.
    ///
    /// All Dashboard users and the app backend share <c>account</c> scoped secrets. Use the
    /// <c>account</c> scope for secrets that don't change per-user, like a third-party API key.
    ///
    /// A <c>user</c> scoped secret is accessible by the app backend and one specific Dashboard
    /// user. Use the <c>user</c> scope for per-user secrets like per-user OAuth tokens, where
    /// different users might have different permissions.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/stripe-apps/store-auth-data-custom-objects">Store data
    /// between page reloads</a>.
    /// </summary>
    public class Secret : StripeEntity<Secret>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// If true, indicates that this secret has been deleted.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool Deleted { get; set; }

        /// <summary>
        /// The Unix timestamp for the expiry time of the secret, after which the secret deletes.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A name for the secret that's unique within the scope.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The plaintext secret value to be stored.
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("scope")]
        public SecretScope Scope { get; set; }
    }
}
