// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentAutomaticPaymentMethods : StripeEntity<SetupIntentAutomaticPaymentMethods>
    {
        /// <summary>
        /// Controls whether this SetupIntent will accept redirect-based payment methods.
        ///
        /// Redirect-based payment methods may require your customer to be redirected to a payment
        /// method's app or site for authentication or additional steps. To <a
        /// href="https://stripe.com/docs/api/setup_intents/confirm">confirm</a> this SetupIntent,
        /// you may be required to provide a <c>return_url</c> to redirect customers back to your
        /// site after they authenticate or complete the setup.
        /// One of: <c>always</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("allow_redirects")]
        public string AllowRedirects { get; set; }

        /// <summary>
        /// Automatically calculates compatible payment methods.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
