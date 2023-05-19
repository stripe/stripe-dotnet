// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsPaypalOptions : INestedOptions
    {
        /// <summary>
        /// The PayPal Billing Agreement ID (BAID). This is an ID generated by PayPal which
        /// represents the mandate between the merchant and the customer.
        /// </summary>
        [JsonProperty("billing_agreement_id")]
        public string BillingAgreementId { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
