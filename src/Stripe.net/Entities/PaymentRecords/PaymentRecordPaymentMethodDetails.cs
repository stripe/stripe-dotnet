// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentRecordPaymentMethodDetails : StripeEntity<PaymentRecordPaymentMethodDetails>
    {
        /// <summary>
        /// The billing details associated with the method of payment.
        /// </summary>
        [JsonProperty("billing_details")]
        public PaymentRecordPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// Information about the custom (user-defined) payment method used to make this payment.
        /// </summary>
        [JsonProperty("custom")]
        public PaymentRecordPaymentMethodDetailsCustom Custom { get; set; }

        /// <summary>
        /// ID of the Stripe PaymentMethod used to make this payment.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The type of payment method used for this payment attempt.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
