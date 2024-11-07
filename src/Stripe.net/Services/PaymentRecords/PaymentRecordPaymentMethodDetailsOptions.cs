// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentRecordPaymentMethodDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The billing details associated with the method of payment.
        /// </summary>
        [JsonProperty("billing_details")]
        public PaymentRecordPaymentMethodDetailsBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// Information about the custom (user-defined) payment method used to make this payment.
        /// </summary>
        [JsonProperty("custom")]
        public PaymentRecordPaymentMethodDetailsCustomOptions Custom { get; set; }

        /// <summary>
        /// ID of the Stripe Payment Method used to make this payment.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The type of the payment method details. An additional hash is included on the
        /// payment_method_details with a name matching this value. It contains additional
        /// information specific to the type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
