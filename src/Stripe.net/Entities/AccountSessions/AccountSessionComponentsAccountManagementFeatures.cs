// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSessionComponentsAccountManagementFeatures : StripeEntity<AccountSessionComponentsAccountManagementFeatures>
    {
        /// <summary>
        /// Whether Stripe user authentication is disabled. This value can only be <c>true</c> for
        /// accounts where <c>controller.requirement_collection</c> is <c>application</c> for the
        /// account. The default value is the opposite of the <c>external_account_collection</c>
        /// value. For example, if you don't set <c>external_account_collection</c>, it defaults to
        /// <c>true</c> and <c>disable_stripe_user_authentication</c> defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disable_stripe_user_authentication")]
#endif
        public bool DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether external account collection is enabled. This feature can only be <c>false</c>
        /// for accounts where you’re responsible for collecting updated information when
        /// requirements are due or change, like Custom accounts. The default value for this feature
        /// is <c>true</c>.
        /// </summary>
        [JsonProperty("external_account_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("external_account_collection")]
#endif
        public bool ExternalAccountCollection { get; set; }
    }
}
