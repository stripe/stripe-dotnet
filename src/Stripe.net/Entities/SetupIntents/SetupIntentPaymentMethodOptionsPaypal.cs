// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsPaypal : StripeEntity<SetupIntentPaymentMethodOptionsPaypal>
    {
        /// <summary>
        /// The ID of the PayPal Billing Agreement.
        /// </summary>
        [JsonProperty("billing_agreement_id")]
        public string BillingAgreementId { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
