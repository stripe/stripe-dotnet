// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsKlarna : StripeEntity<PaymentIntentPaymentMethodOptionsKlarna>
    {
        /// <summary>
        /// Preferred locale of the Klarna checkout page that the customer is redirected to.
        /// </summary>
        [JsonProperty("preferred_locale")]
        public string PreferredLocale { get; set; }
    }
}
