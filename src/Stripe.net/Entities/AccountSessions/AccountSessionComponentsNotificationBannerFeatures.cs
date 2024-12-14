// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsNotificationBannerFeatures : StripeEntity<AccountSessionComponentsNotificationBannerFeatures>
    {
        /// <summary>
        /// Disables Stripe user authentication for this embedded component. This value can only be
        /// true for accounts where <c>controller.requirement_collection</c> is <c>application</c>.
        /// The default value is the opposite of the <c>external_account_collection</c> value. For
        /// example, if you don’t set <c>external_account_collection</c>, it defaults to true and
        /// <c>disable_stripe_user_authentication</c> defaults to false.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
        public bool DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether to allow platforms to control bank account collection for their connected
        /// accounts. This feature can only be false for accounts where you’re responsible for
        /// collecting updated information when requirements are due or change, like custom
        /// accounts. Otherwise, bank account collection is determined by compliance requirements.
        /// The default value for this feature is <c>true</c>.
        /// </summary>
        [JsonProperty("external_account_collection")]
        public bool ExternalAccountCollection { get; set; }
    }
}
