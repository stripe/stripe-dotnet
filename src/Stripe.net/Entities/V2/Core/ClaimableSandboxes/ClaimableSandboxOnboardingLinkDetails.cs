// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ClaimableSandboxOnboardingLinkDetails : StripeEntity<ClaimableSandboxOnboardingLinkDetails>
    {
        /// <summary>
        /// Time at which the onboarding link expires. Represented as an RFC 3339 timestamp in UTC
        /// with millisecond precision, for example <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("expires_at")]
        [STJS.JsonPropertyName("expires_at")]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL the user will be redirected to if the onboarding link is expired or invalid. The
        /// URL specified should attempt to generate a new onboarding link, and re-direct the user
        /// to this new onboarding link so that they can proceed with the onboarding flow.
        /// </summary>
        [JsonProperty("refresh_url")]
        [STJS.JsonPropertyName("refresh_url")]
        public string RefreshUrl { get; set; }

        /// <summary>
        /// The URL offered to the user as a way back to your app after they claim the sandbox.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The URL that lets a user claim the sandbox or continue onboarding their Stripe account,
        /// depending on the sandbox's status.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
