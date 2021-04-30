// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentNextAction : StripeEntity<SetupIntentNextAction>
    {
        [JsonProperty("redirect_to_url")]
        public SetupIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        /// <summary>
        /// Type of the next action to perform, one of <c>redirect_to_url</c>,
        /// <c>use_stripe_sdk</c>, <c>alipay_handle_redirect</c>, or <c>oxxo_display_details</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("verify_with_microdeposits")]
        public SetupIntentNextActionVerifyWithMicrodeposits VerifyWithMicrodeposits { get; set; }
    }
}
