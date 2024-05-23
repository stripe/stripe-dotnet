// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsBalancesFeatures : StripeEntity<AccountSessionComponentsBalancesFeatures>
    {
        /// <summary>
        /// Whether to allow payout schedule to be changed. Default <c>true</c> when Stripe owns
        /// Loss Liability, default <c>false</c> otherwise.
        /// </summary>
        [JsonProperty("edit_payout_schedule")]
        public bool EditPayoutSchedule { get; set; }

        /// <summary>
        /// Whether to allow platforms to control bank account collection for their connected
        /// accounts. This feature can only be false for custom accounts (or accounts where the
        /// platform is compliance owner). Otherwise, bank account collection is determined by
        /// compliance requirements.
        /// </summary>
        [JsonProperty("external_account_collection")]
        public bool ExternalAccountCollection { get; set; }

        /// <summary>
        /// Whether to allow creation of instant payouts. Default <c>true</c> when Stripe owns Loss
        /// Liability, default <c>false</c> otherwise.
        /// </summary>
        [JsonProperty("instant_payouts")]
        public bool InstantPayouts { get; set; }

        /// <summary>
        /// Whether to allow creation of standard payouts. Default <c>true</c> when Stripe owns Loss
        /// Liability, default <c>false</c> otherwise.
        /// </summary>
        [JsonProperty("standard_payouts")]
        public bool StandardPayouts { get; set; }
    }
}
