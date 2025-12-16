// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsCardPresent : StripeEntity<PaymentIntentPaymentMethodOptionsCardPresent>
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
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

        [JsonProperty("routing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing")]
#endif
        public PaymentIntentPaymentMethodOptionsCardPresentRouting Routing { get; set; }
    }
}
