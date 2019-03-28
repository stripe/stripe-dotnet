namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class OAuthToken : StripeEntity<OAuthToken>
    {
        /// <summary>
        /// <para>
        /// The access token you can use to make requests on behalf of this Stripe account. Use it
        /// as you would any Stripe secret API key.
        /// </para>
        /// <para>
        /// This key does not expire, but may be revoked by the user at any time (you'll get a
        /// <c>account.application.deauthorized</c>
        /// <see href="https://stripe.com/docs/api/events/types#event_types-account.application.authorized">webhook event</see>
        /// when this happens).
        /// </para>
        /// </summary>
        /// <remarks>
        /// This property is deprecated. In backend code, it is recommended that you use your own
        /// secret key in conjunction with the connected account's ID found in
        /// <see cref="StripeUserId"/>.
        /// </remarks>
        [Obsolete("Use StripeUserId instead.")]
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>
        /// The live mode indicator for the token. If <c>true</c>, the <see cref="AccessToken"/>
        /// can be used as a live secret key. If <c>false</c>, the <see cref="AccessToken"/> can be
        /// used as a test secret key.
        /// </para>
        /// <para>Depends on the mode of the secret API key used to make the request.</para>
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Can be used to get a new access token of an equal or lesser scope, or of a different
        /// live mode (where
        /// <see href="https://stripe.com/docs/connect/testing#test-keys-for-livemode-applications">applicable</see>).
        /// </summary>
        /// <remarks>
        /// This property is deprecated. In backend code, it is recommended that you don't use
        /// access tokens or refresh tokens at all. Instead, you should use your own secret key in
        /// conjunction with the connected account's ID found in <see cref="StripeUserId"/>.
        /// </remarks>
        [Obsolete("Use StripeUserId instead.")]
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// The scope granted to the access token, depending on the scope of the authorization code
        /// and <c>scope</c> parameter.
        /// </summary>
        [JsonProperty("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// A publishable key that can be used with this account. Matches the mode—live or test—of
        /// the token.
        /// </summary>
        /// <remarks>
        /// This property is deprecated. In frontend code, it is recommended that you use your own
        /// publishable key in conjunction with the connected account's ID found in
        /// <see cref="StripeUserId"/>.
        /// </remarks>
        [Obsolete("Use StripeUserId instead.")]
        [JsonProperty("stripe_publishable_key")]
        public string StripePublishableKey { get; set; }

        /// <summary>
        /// The unique id of the account you have been granted access to, as a string.
        /// </summary>
        [JsonProperty("stripe_user_id")]
        public string StripeUserId { get; set; }

        /// <summary>Will always have a value of <c>bearer</c>.</summary>
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }
}
