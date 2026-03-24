// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountControllerApplicationOptions : INestedOptions
    {
        /// <summary>
        /// Whether the controller is liable for losses on this account. For details, see <a
        /// href="https://docs.stripe.com/connect/account-balances">Understanding Connect Account
        /// Balances</a>.
        /// </summary>
        [JsonProperty("loss_liable")]
        [STJS.JsonPropertyName("loss_liable")]
        public bool? LossLiable { get; set; }

        /// <summary>
        /// Whether the controller owns onboarding for this account.
        /// </summary>
        [JsonProperty("onboarding_owner")]
        [STJS.JsonPropertyName("onboarding_owner")]
        public bool? OnboardingOwner { get; set; }

        /// <summary>
        /// Whether the controller has pricing controls for this account.
        /// </summary>
        [JsonProperty("pricing_controls")]
        [STJS.JsonPropertyName("pricing_controls")]
        public bool? PricingControls { get; set; }
    }
}
