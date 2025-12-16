// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsCardPresentOptions : INestedOptions
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
        /// One of: <c>manual</c>, or <c>manual_preferred</c>.
        /// </summary>
        [JsonProperty("capture_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture_method")]
#endif
        public string CaptureMethod { get; set; }

        /// <summary>
        /// Request ability to capture this payment beyond the standard <a
        /// href="https://docs.stripe.com/terminal/features/extended-authorizations#authorization-validity">authorization
        /// validity window</a>.
        /// </summary>
        [JsonProperty("request_extended_authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request_extended_authorization")]
#endif
        public bool? RequestExtendedAuthorization { get; set; }

        /// <summary>
        /// Request ability to <a
        /// href="https://docs.stripe.com/terminal/features/incremental-authorizations">increment</a>
        /// this PaymentIntent if the combination of MCC and card brand is eligible. Check <a
        /// href="https://docs.stripe.com/api/charges/object#charge_object-payment_method_details-card_present-incremental_authorization_supported">incremental_authorization_supported</a>
        /// in the <a href="https://docs.stripe.com/api/payment_intents/confirm">Confirm</a>
        /// response to verify support.
        /// </summary>
        [JsonProperty("request_incremental_authorization_support")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request_incremental_authorization_support")]
#endif
        public bool? RequestIncrementalAuthorizationSupport { get; set; }

        /// <summary>
        /// Network routing priority on co-branded EMV cards supporting domestic debit and
        /// international card schemes.
        /// </summary>
        [JsonProperty("routing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing")]
#endif
        public PaymentIntentPaymentMethodOptionsCardPresentRoutingOptions Routing { get; set; }
    }
}
