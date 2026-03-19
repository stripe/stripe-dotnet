// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An AccountSession allows a Connect platform to grant access to a connected account in
    /// Connect embedded components.
    ///
    /// We recommend that you create an AccountSession each time you need to display an embedded
    /// component to your user. Do not save AccountSessions to your database as they expire
    /// relatively quickly, and cannot be used more than once.
    ///
    /// Related guide: <a
    /// href="https://docs.stripe.com/connect/get-started-connect-embedded-components">Connect
    /// embedded components</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSession : StripeEntity<AccountSession>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The ID of the account the AccountSession was created for.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The client secret of this AccountSession. Used on the client to set up secure access to
        /// the given <c>account</c>.
        ///
        /// The client secret can be used to provide access to <c>account</c> from your frontend. It
        /// should not be stored, logged, or exposed to anyone other than the connected account.
        /// Make sure that you have TLS enabled on any page that includes the client secret.
        ///
        /// Refer to our docs to <a
        /// href="https://docs.stripe.com/connect/get-started-connect-embedded-components">setup
        /// Connect embedded components</a> and learn about how <c>client_secret</c> should be
        /// handled.
        /// </summary>
        [JsonProperty("client_secret")]
        [STJS.JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("components")]
        [STJS.JsonPropertyName("components")]
        public AccountSessionComponents Components { get; set; }

        /// <summary>
        /// The timestamp at which this AccountSession will expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }
    }
}
