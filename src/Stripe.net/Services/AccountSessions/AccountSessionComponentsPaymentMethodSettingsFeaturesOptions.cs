// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSessionComponentsPaymentMethodSettingsFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Whether Stripe user authentication is disabled. This value can only be <c>true</c> for
        /// accounts where <c>controller.requirement_collection</c> is <c>application</c> for the
        /// account. This is <c>false</c> by default.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
        [STJS.JsonPropertyName("disable_stripe_user_authentication")]
        public bool? DisableStripeUserAuthentication { get; set; }
    }
}
