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

        /// <summary>
        /// A unique reference ID of the PayPal transaction. This must be a globally unique ID
        /// across all PayPal transactions or the transaction will fail.
        /// </summary>
        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }
    }
}
