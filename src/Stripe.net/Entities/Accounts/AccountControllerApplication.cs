// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountControllerApplication : StripeEntity<AccountControllerApplication>
    {
        /// <summary>
        /// <c>true</c> if the Connect application is responsible for negative balances and should
        /// manage credit and fraud risk on the account.
        /// </summary>
        [JsonProperty("loss_liable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("loss_liable")]
#endif
        public bool LossLiable { get; set; }

        /// <summary>
        /// <c>true</c> if the Connect application is responsible for onboarding the account.
        /// </summary>
        [JsonProperty("onboarding_owner")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("onboarding_owner")]
#endif
        public bool OnboardingOwner { get; set; }

        /// <summary>
        /// <c>true</c> if the Connect application is responsible for paying Stripe fees on
        /// pricing-control eligible products.
        /// </summary>
        [JsonProperty("pricing_controls")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_controls")]
#endif
        public bool PricingControls { get; set; }
    }
}
