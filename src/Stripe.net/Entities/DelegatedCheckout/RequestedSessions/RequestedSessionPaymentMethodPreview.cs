// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionPaymentMethodPreview : StripeEntity<RequestedSessionPaymentMethodPreview>
    {
        /// <summary>
        /// The billing details of the payment method.
        /// </summary>
        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public RequestedSessionPaymentMethodPreviewBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// The card details of the payment method.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public RequestedSessionPaymentMethodPreviewCard Card { get; set; }

        /// <summary>
        /// The type of the payment method.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
