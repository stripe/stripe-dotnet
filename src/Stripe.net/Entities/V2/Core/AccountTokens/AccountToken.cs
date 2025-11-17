// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Account tokens are single-use tokens which tokenize company/individual/business
    /// information, and are used for creating or updating an Account.
    /// </summary>
    public class AccountToken : StripeEntity<AccountToken>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the token.
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
        /// Time at which the token was created. Represented as a RFC 3339 date &amp; time UTC value
        /// in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the token will expire.
        /// </summary>
        [JsonProperty("expires_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the token exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Determines if the token has already been used (tokens can only be used once).
        /// </summary>
        [JsonProperty("used")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("used")]
#endif
        public bool Used { get; set; }
    }
}
