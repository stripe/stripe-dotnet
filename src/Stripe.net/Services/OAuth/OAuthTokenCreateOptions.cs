namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OAuthTokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// If you <see href="https://stripe.com/docs/connect/express-accounts#specify-capabilities">specified a Capability</see>
        /// using the <see cref="OAuthAuthorizeUrlOptions.SuggestedCapabilities"/> parameter, you
        /// can verify that Stripe applied the suggested Capability in this POST request by
        /// including <see cref="AssertCapabilities"/> and identifying that <c>card_payments</c> or
        /// <c>transfers</c> match. A request error will be returned if the suggested
        /// <see href="https://stripe.com/docs/connect/capabilities-overview">Capability</see>
        /// doesn't match the assertion: in this case, it's recommended to end the onboarding flow
        /// with a failure.
        /// </summary>
        [JsonProperty("assert_capabilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("assert_capabilities")]
#endif
        public List<string> AssertCapabilities { get; set; }

        /// <summary>
        /// The secret API key. When converting an authorization code to an access token, you must
        /// use an API key that matches the mode—live or test—of the authorization code (which
        /// depends on whether the <c>client_id</c> used was production or development).
        /// </summary>
        [JsonProperty("client_secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_secret")]
#endif
        public string ClientSecret { get; set; }

        /// <summary>The value of the <c>code</c>, depending on the <c>grant_type</c>.</summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }

        /// <summary>
        /// <c>authorization_code</c> when turning an authorization code into an access token, or
        /// <c>refresh_token</c> when using a refresh token to get a new access token.
        /// </summary>
        [JsonProperty("grant_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grant_type")]
#endif
        public string GrantType { get; set; }

        /// <summary>The value of the <c>refresh_token</c>, depending on the <c>grant_type</c>.</summary>
        [JsonProperty("refresh_token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refresh_token")]
#endif
        public string RefreshToken { get; set; }

        /// <summary>
        /// <para>
        /// When requesting a new access token from a refresh token, any scope that has an equal or
        /// lesser scope as the refresh token. Has no effect when requesting an access token from an
        /// authorization code.
        /// </para>
        /// <para>Defaults to the scope of the refresh token.</para>
        /// </summary>
        [JsonProperty("scope")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("scope")]
#endif
        public string Scope { get; set; }
    }
}
