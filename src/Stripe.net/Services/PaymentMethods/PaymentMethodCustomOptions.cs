// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentMethodCustomOptions : INestedOptions
    {
        /// <summary>
        /// A reference to an external payment method, such as a PayPal Billing Agreement ID.
        /// </summary>
        [JsonProperty("payment_method_reference")]
        [STJS.JsonPropertyName("payment_method_reference")]
        public string PaymentMethodReference { get; set; }

        /// <summary>
        /// ID of the Dashboard-only CustomPaymentMethodType. This field is used by Stripe products'
        /// internal code to support CPMs.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Indicates whether the payment method supports off-session payments.
        /// </summary>
        [JsonProperty("usage")]
        [STJS.JsonPropertyName("usage")]
        public string Usage { get; set; }
    }
}
