// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodCustomOptions : INestedOptions
    {
        /// <summary>
        /// A reference to an external payment method, such as a PayPal Billing Agreement ID.
        /// </summary>
        [JsonProperty("payment_method_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_reference")]
#endif
        public string PaymentMethodReference { get; set; }

        /// <summary>
        /// ID of the Dashboard-only CustomPaymentMethodType. This field is used by Stripe products'
        /// internal code to support CPMs.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
