// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsUserAccessAuthenticationPrimaryFactor : StripeEntity<ActivityLogDetailsUserAccessAuthenticationPrimaryFactor>
    {
        /// <summary>
        /// SSO provider for the authentication factor.
        /// </summary>
        [JsonProperty("sso_provider")]
        [STJS.JsonPropertyName("sso_provider")]
        public string SsoProvider { get; set; }

        /// <summary>
        /// Type of authentication factor.
        /// One of: <c>backup_code</c>, <c>email_code</c>, <c>oauth</c>, <c>passkey</c>,
        /// <c>password</c>, <c>phone_code</c>, <c>saml</c>, <c>sms</c>, <c>totp</c>, or
        /// <c>web_authn</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
