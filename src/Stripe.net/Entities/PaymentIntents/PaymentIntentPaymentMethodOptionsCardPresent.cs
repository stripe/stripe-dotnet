// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPresent : StripeEntity<PaymentIntentPaymentMethodOptionsCardPresent>
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// One of: <c>manual</c>, or <c>manual_preferred</c>.
        /// </summary>
        [JsonProperty("capture_method")]
        [STJS.JsonPropertyName("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// Request ability to capture this payment beyond the standard <a
        /// href="https://docs.stripe.com/terminal/features/extended-authorizations#authorization-validity">authorization
        /// validity window</a>.
        /// </summary>
        [JsonProperty("request_extended_authorization")]
        [STJS.JsonPropertyName("request_extended_authorization")]
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
        [STJS.JsonPropertyName("request_incremental_authorization_support")]
        public bool? RequestIncrementalAuthorizationSupport { get; set; }

        [JsonProperty("routing")]
        [STJS.JsonPropertyName("routing")]
        public PaymentIntentPaymentMethodOptionsCardPresentRouting Routing { get; set; }

        /// <summary>
        /// Request ability to <a
        /// href="https://docs.stripe.com/payments/reauthorization">reauthorize</a> for this
        /// PaymentIntent.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_reauthorization")]
        [STJS.JsonPropertyName("request_reauthorization")]
        public string RequestReauthorization { get; set; }
    }
}
