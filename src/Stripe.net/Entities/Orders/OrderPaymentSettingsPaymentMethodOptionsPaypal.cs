// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderPaymentSettingsPaymentMethodOptionsPaypal : StripeEntity<OrderPaymentSettingsPaymentMethodOptionsPaypal>
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// Preferred locale of the PayPal checkout page that the customer is redirected to.
        /// </summary>
        [JsonProperty("preferred_locale")]
        public string PreferredLocale { get; set; }
    }
}
