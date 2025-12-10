// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Account Links let a platform create a temporary, single-use URL that an account can use
    /// to access a Stripe-hosted flow for collecting or updating required information.
    /// </summary>
    public class AccountLink : StripeEntity<AccountLink>, IHasObject
    {
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
        /// The ID of the connected account this Account Link applies to.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The timestamp at which this Account Link was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The timestamp at which this Account Link will expire.
        /// </summary>
        [JsonProperty("expires_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        /// The URL at which the account can access the Stripe-hosted flow.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }

        /// <summary>
        /// Hash containing usage options.
        /// </summary>
        [JsonProperty("use_case")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("use_case")]
#endif
        public AccountLinkUseCase UseCase { get; set; }
    }
}
