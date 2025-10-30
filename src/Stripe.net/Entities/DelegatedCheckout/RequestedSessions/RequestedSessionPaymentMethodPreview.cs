// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionPaymentMethodPreview : StripeEntity<RequestedSessionPaymentMethodPreview>
    {
        /// <summary>
        /// The billing details of the payment method.
        /// </summary>
        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif
        public RequestedSessionPaymentMethodPreviewBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// The card details of the payment method.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public RequestedSessionPaymentMethodPreviewCard Card { get; set; }

        /// <summary>
        /// The type of the payment method.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
