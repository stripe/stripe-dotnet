// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsNaverPayOptions : INestedOptions
    {
        /// <summary>
        /// Controls when the funds are captured from the customer's account.
        ///
        /// If provided, this parameter overrides the behavior of the top-level <a
        /// href="https://stripe.com/api/payment_intents/update#update_payment_intent-capture_method">capture_method</a>
        /// for this payment method type when finalizing the payment with this payment method type.
        ///
        /// If <c>capture_method</c> is already set on the PaymentIntent, providing an empty value
        /// for this parameter unsets the stored value for this payment method type.
        /// </summary>
        [JsonProperty("capture_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture_method")]
#endif
        public string CaptureMethod { get; set; }
    }
}
