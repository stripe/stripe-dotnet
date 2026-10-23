// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionResourceComponentsPaymentMethodSettingsScopes : StripeEntity<AccountSessionResourceComponentsPaymentMethodSettingsScopes>
    {
        /// <summary>
        /// Whether to disable Stripe user authentication in the enabled components.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
        [STJS.JsonPropertyName("disable_stripe_user_authentication")]
        public string DisableStripeUserAuthentication { get; set; }
    }
}
