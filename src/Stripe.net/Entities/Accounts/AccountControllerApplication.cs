// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountControllerApplication : StripeEntity<AccountControllerApplication>
    {
        /// <summary>
        /// <c>true</c> if the Connect application is responsible for negative balances and should
        /// manage credit and fraud risk on the account.
        /// </summary>
        [JsonProperty("loss_liable")]
        public bool LossLiable { get; set; }

        /// <summary>
        /// <c>true</c> if the Connect application is responsible for onboarding the account.
        /// </summary>
        [JsonProperty("onboarding_owner")]
        public bool OnboardingOwner { get; set; }

        /// <summary>
        /// <c>true</c> if the Connect application is responsible for paying Stripe fees on
        /// pricing-control eligible products.
        /// </summary>
        [JsonProperty("pricing_controls")]
        public bool PricingControls { get; set; }
    }
}
