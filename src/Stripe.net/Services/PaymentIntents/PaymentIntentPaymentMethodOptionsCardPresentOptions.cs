// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsCardPresentOptions : INestedOptions
    {
        /// <summary>
        /// Request ability to capture this payment beyond the standard <a
        /// href="https://stripe.com/docs/terminal/features/extended-authorizations#authorization-validity">authorization
        /// validity window</a>.
        /// </summary>
        [JsonProperty("request_extended_authorization")]
        public bool? RequestExtendedAuthorization { get; set; }

        /// <summary>
        /// This field was released by mistake and will be removed in the next major version.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_incremental_authorization")]
        public string RequestIncrementalAuthorization { get; set; }

        /// <summary>
        /// Request ability to <a
        /// href="https://stripe.com/docs/terminal/features/incremental-authorizations">increment</a>
        /// this PaymentIntent if the combination of MCC and card brand is eligible. Check <a
        /// href="https://stripe.com/docs/api/charges/object#charge_object-payment_method_details-card_present-incremental_authorization_supported">incremental_authorization_supported</a>
        /// in the <a href="https://stripe.com/docs/api/payment_intents/confirm">Confirm</a>
        /// response to verify support.
        /// </summary>
        [JsonProperty("request_incremental_authorization_support")]
        public bool? RequestIncrementalAuthorizationSupport { get; set; }
    }
}
