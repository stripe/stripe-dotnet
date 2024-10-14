namespace Stripe
{
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif

    public class AccountController : StripeEntity<AccountController>
    {
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("fees")]
#else
        [JsonProperty("fees")]
#endif
        public AccountControllerFees Fees { get; set; }

        /// <summary>
        /// <c>true</c> if the Connect application retrieving the resource controls the account and
        /// can therefore exercise <a
        /// href="https://stripe.com/docs/connect/platform-controls-for-standard-accounts">platform
        /// controls</a>. Otherwise, this field is null.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("is_controller")]
#else
        [JsonProperty("is_controller")]
#endif
        public bool IsController { get; set; }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("losses")]
#else
        [JsonProperty("losses")]
#endif
        public AccountControllerLosses Losses { get; set; }

        /// <summary>
        /// A value indicating responsibility for collecting requirements on this account. Only
        /// returned when the Connect application retrieving the resource controls the account.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("requirement_collection")]
#else
        [JsonProperty("requirement_collection")]
#endif
        public string RequirementCollection { get; set; }

#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("stripe_dashboard")]
#else
        [JsonProperty("stripe_dashboard")]
#endif
        public AccountControllerStripeDashboard StripeDashboard { get; set; }

        /// <summary>
        /// The controller type. Can be <c>application</c>, if a Connect application controls the
        /// account, or <c>account</c>, if the account controls itself.
        /// One of: <c>account</c>, or <c>application</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("type")]
#else
        [JsonProperty("type")]
#endif
        public string Type { get; set; }
    }
}
