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
        /// The timestamp the onboarding link expires.
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
        /// URL that will redirect the user to either claim or onboard the claimable sandbox
        /// depending on its status.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
