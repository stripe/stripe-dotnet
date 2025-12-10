// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountLinkCreateUseCaseOptions : INestedOptions
    {
        /// <summary>
        /// Open Enum. The type of Account Link the user is requesting.
        /// One of: <c>account_onboarding</c>, or <c>account_update</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Hash containing configuration options for an Account Link object that onboards a new
        /// account.
        /// </summary>
        [JsonProperty("account_onboarding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_onboarding")]
#endif
        public AccountLinkCreateUseCaseAccountOnboardingOptions AccountOnboarding { get; set; }

        /// <summary>
        /// Hash containing configuration options for an Account Link that updates an existing
        /// account.
        /// </summary>
        [JsonProperty("account_update")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_update")]
#endif
        public AccountLinkCreateUseCaseAccountUpdateOptions AccountUpdate { get; set; }
    }
}
