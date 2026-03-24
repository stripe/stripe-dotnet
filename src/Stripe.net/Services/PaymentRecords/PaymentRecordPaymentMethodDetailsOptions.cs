// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordPaymentMethodDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The billing details associated with the method of payment.
        /// </summary>
        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public PaymentRecordPaymentMethodDetailsBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// Information about the custom (user-defined) payment method used to make this payment.
        /// </summary>
        [JsonProperty("custom")]
        [STJS.JsonPropertyName("custom")]
        public PaymentRecordPaymentMethodDetailsCustomOptions Custom { get; set; }

        /// <summary>
        /// ID of the Stripe Payment Method used to make this payment.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The type of the payment method details. An additional hash is included on the
        /// payment_method_details with a name matching this value. It contains additional
        /// information specific to the type.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
