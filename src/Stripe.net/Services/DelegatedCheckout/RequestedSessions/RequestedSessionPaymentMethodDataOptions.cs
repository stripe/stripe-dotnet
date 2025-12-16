// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionPaymentMethodDataOptions : INestedOptions
    {
        /// <summary>
        /// The billing details for the payment method data.
        /// </summary>
        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif
        public RequestedSessionPaymentMethodDataBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// The card for the payment method data.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public RequestedSessionPaymentMethodDataCardOptions Card { get; set; }

        /// <summary>
        /// The type of the payment method data.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
