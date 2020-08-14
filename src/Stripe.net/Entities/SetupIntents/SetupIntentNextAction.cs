namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentNextAction : StripeEntity<SetupIntentNextAction>
    {
        [JsonProperty("redirect_to_url")]
        public SetupIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        /// <summary>
        /// Type of the next action to perform, one of <c>redirect_to_url</c> or
        /// <c>use_stripe_sdk</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
