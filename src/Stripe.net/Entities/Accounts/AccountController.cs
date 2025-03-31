// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountController : StripeEntity<AccountController>
    {
        [JsonProperty("fees")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fees")]
#endif
        public AccountControllerFees Fees { get; set; }

        /// <summary>
        /// <c>true</c> if the Connect application retrieving the resource controls the account and
        /// can therefore exercise <a
        /// href="https://stripe.com/docs/connect/platform-controls-for-standard-accounts">platform
        /// controls</a>. Otherwise, this field is null.
        /// </summary>
        [JsonProperty("is_controller")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_controller")]
#endif
        public bool IsController { get; set; }

        [JsonProperty("losses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("losses")]
#endif
        public AccountControllerLosses Losses { get; set; }

        /// <summary>
        /// A value indicating responsibility for collecting requirements on this account. Only
        /// returned when the Connect application retrieving the resource controls the account.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("requirement_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requirement_collection")]
#endif
        public string RequirementCollection { get; set; }

        [JsonProperty("stripe_dashboard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_dashboard")]
#endif
        public AccountControllerStripeDashboard StripeDashboard { get; set; }

        /// <summary>
        /// The controller type. Can be <c>application</c>, if a Connect application controls the
        /// account, or <c>account</c>, if the account controls itself.
        /// One of: <c>account</c>, or <c>application</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
