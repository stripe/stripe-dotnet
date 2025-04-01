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
        /// Open Enum. The type of AccountLink the user is requesting.
        /// One of: <c>account_onboarding</c>, or <c>account_update</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Indicates that the AccountLink provided should onboard an account.
        /// </summary>
        [JsonProperty("account_onboarding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_onboarding")]
#endif
        public AccountLinkCreateUseCaseAccountOnboardingOptions AccountOnboarding { get; set; }

        /// <summary>
        /// Indicates that the AccountLink provided should update a previously onboarded account.
        /// </summary>
        [JsonProperty("account_update")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_update")]
#endif
        public AccountLinkCreateUseCaseAccountUpdateOptions AccountUpdate { get; set; }
    }
}
