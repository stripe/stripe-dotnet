// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountControllerApplicationOptions : INestedOptions
    {
        /// <summary>
        /// Whether the controller is liable for losses on this account. For details, see <a
        /// href="https://stripe.com/docs/connect/account-balances">Understanding Connect Account
        /// Balances</a>.
        /// </summary>
        [JsonProperty("loss_liable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("loss_liable")]
#endif
        public bool? LossLiable { get; set; }

        /// <summary>
        /// Whether the controller owns onboarding for this account.
        /// </summary>
        [JsonProperty("onboarding_owner")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("onboarding_owner")]
#endif
        public bool? OnboardingOwner { get; set; }

        /// <summary>
        /// Whether the controller has pricing controls for this account.
        /// </summary>
        [JsonProperty("pricing_controls")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_controls")]
#endif
        public bool? PricingControls { get; set; }
    }
}
