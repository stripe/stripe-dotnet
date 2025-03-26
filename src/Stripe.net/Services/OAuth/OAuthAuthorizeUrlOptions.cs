namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OAuthAuthorizeUrlOptions : BaseOptions
    {
        /// <summary>
        /// Boolean to indicate that the user should always be asked to connect, even if they're
        /// already connected. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("always_prompt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("always_prompt")]
#endif
        public bool? AlwaysPrompt { get; set; }

        /// <summary>
        /// The unique identifier provided to your application, found in your
        /// <see href="https://dashboard.stripe.com/account/applications/settings">application settings</see>.
        /// </summary>
        [JsonProperty("client_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_id")]
#endif
        public string ClientId { get; set; }

        /// <summary>The only option at the moment is <c>code</c>.</summary>
        [JsonProperty("response_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("response_type")]
#endif
        public string ResponseType { get; set; } = "code";

        /// <summary>
        /// <para>
        /// The URL for the authorize
        /// <see href="https://stripe.com/docs/connect/oauth-reference#get-authorize-response">response</see>
        ///  redirect. If provided, this must exactly match one of the comma-separated
        /// <c>redirect_uri</c> values in your
        /// <see href="https://dashboard.stripe.com/account/applications/settings">application settings</see>.
        /// </para>
        /// <para>
        /// To protect yourself from certain forms of man-in-the-middle attacks, the live mode
        /// <c>redirect_uri</c> must use a secure HTTPS connection.
        /// </para>
        /// <para>
        /// Defaults to the <c>redirect_uri</c> in your application settings if not provided.
        /// </para>
        /// </summary>
        [JsonProperty("redirect_uri")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redirect_uri")]
#endif
        public string RedirectUri { get; set; }

        /// <summary>
        /// <c>read_write</c> or <c>read_only</c>, depending on the level of access you need.
        /// Defaults to <c>read_only</c>.
        /// </summary>
        [JsonProperty("scope")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("scope")]
#endif
        public string Scope { get; set; }

        /// <summary>
        /// An arbitrary string value we will pass back to you, useful for CSRF protection.
        /// </summary>
        [JsonProperty("state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state")]
#endif
        public string State { get; set; }

        /// <summary>
        /// <para>
        /// <c>login</c> or <c>register</c>, depending on what type of screen you want your users
        /// to see. Only override this to be <c>login</c> if you expect all your users to have
        /// Stripe accounts already (e.g., most read-only applications, like analytics dashboards or
        /// accounting software).
        /// </para>
        /// <para>
        /// Defaults to <c>login</c> for scope <c>read_only</c> and <c>register</c> for scope
        /// <c>read_write</c>.
        /// </para>
        /// </summary>
        [JsonProperty("stripe_landing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_landing")]
#endif
        public string StripeLanding { get; set; }

        /// <summary>Prefilled details in the account form for new users.</summary>
        [JsonProperty("stripe_user")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_user")]
#endif
        public OAuthAuthorizeUrlStripeUserOptions StripeUser { get; set; }

        /// <summary>
        /// If your platform is designated for one
        /// <see href="https://stripe.com/docs/connect/capabilities-overview">Capability</see>
        /// (either <c>card_payments</c> or <c>transfers</c>), you won't need to specify
        /// additional Capabilities. However, if your platform supports both, you can add a
        /// Capability to an individual Express account by including the
        /// <see cref="SuggestedCapabilities"/> parameter in your OAuth link.
        /// </summary>
        [JsonProperty("suggested_capabilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("suggested_capabilities")]
#endif
        public List<string> SuggestedCapabilities { get; set; }
    }
}
