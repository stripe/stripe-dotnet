// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionPaymentMethodDataOptions : INestedOptions
    {
        /// <summary>
        /// The billing details for the payment method data.
        /// </summary>
        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public RequestedSessionPaymentMethodDataBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// The card for the payment method data.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public RequestedSessionPaymentMethodDataCardOptions Card { get; set; }

        /// <summary>
        /// The type of the payment method data.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
