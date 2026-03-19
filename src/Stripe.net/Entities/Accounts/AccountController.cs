// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountController : StripeEntity<AccountController>
    {
        [JsonProperty("fees")]
        [STJS.JsonPropertyName("fees")]
        public AccountControllerFees Fees { get; set; }

        /// <summary>
        /// <c>true</c> if the Connect application retrieving the resource controls the account and
        /// can therefore exercise <a
        /// href="https://docs.stripe.com/connect/platform-controls-for-standard-accounts">platform
        /// controls</a>. Otherwise, this field is null.
        /// </summary>
        [JsonProperty("is_controller")]
        [STJS.JsonPropertyName("is_controller")]
        public bool IsController { get; set; }

        [JsonProperty("losses")]
        [STJS.JsonPropertyName("losses")]
        public AccountControllerLosses Losses { get; set; }

        /// <summary>
        /// A value indicating responsibility for collecting requirements on this account. Only
        /// returned when the Connect application retrieving the resource controls the account.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("requirement_collection")]
        [STJS.JsonPropertyName("requirement_collection")]
        public string RequirementCollection { get; set; }

        [JsonProperty("stripe_dashboard")]
        [STJS.JsonPropertyName("stripe_dashboard")]
        public AccountControllerStripeDashboard StripeDashboard { get; set; }

        /// <summary>
        /// The controller type. Can be <c>application</c>, if a Connect application controls the
        /// account, or <c>account</c>, if the account controls itself.
        /// One of: <c>account</c>, or <c>application</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
