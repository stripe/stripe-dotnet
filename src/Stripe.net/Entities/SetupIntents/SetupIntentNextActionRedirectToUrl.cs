namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentNextActionRedirectToUrl : StripeEntity<SetupIntentNextActionRedirectToUrl>
    {
        /// <summary>
        /// If the customer does not exit their browser while authenticating, they will be
        /// redirected to this specified URL after completion.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The URL you must redirect your customer to in order to authenticate.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
