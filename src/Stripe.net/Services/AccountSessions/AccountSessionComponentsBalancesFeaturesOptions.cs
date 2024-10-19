// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsBalancesFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Disables Stripe user authentication for this embedded component. This feature can only
        /// be false for accounts where you’re responsible for collecting updated information when
        /// requirements are due or change, like custom accounts. The default value for this feature
        /// is <c>false</c> when <c>external_account_collection</c> is enabled and <c>true</c>
        /// otherwise.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
        public bool? DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether to allow payout schedule to be changed. Default <c>true</c> when Stripe owns
        /// Loss Liability, default <c>false</c> otherwise.
        /// </summary>
        [JsonProperty("edit_payout_schedule")]
        public bool? EditPayoutSchedule { get; set; }

        /// <summary>
        /// Whether to allow platforms to control bank account collection for their connected
        /// accounts. This feature can only be false for accounts where you’re responsible for
        /// collecting updated information when requirements are due or change, like custom
        /// accounts. Otherwise, bank account collection is determined by compliance requirements.
        /// The default value for this feature is <c>true</c>.
        /// </summary>
        [JsonProperty("external_account_collection")]
        public bool? ExternalAccountCollection { get; set; }

        /// <summary>
        /// Whether to allow creation of instant payouts. Default <c>true</c> when Stripe owns Loss
        /// Liability, default <c>false</c> otherwise.
        /// </summary>
        [JsonProperty("instant_payouts")]
        public bool? InstantPayouts { get; set; }

        /// <summary>
        /// Whether to allow creation of standard payouts. Default <c>true</c> when Stripe owns Loss
        /// Liability, default <c>false</c> otherwise.
        /// </summary>
        [JsonProperty("standard_payouts")]
        public bool? StandardPayouts { get; set; }
    }
}
