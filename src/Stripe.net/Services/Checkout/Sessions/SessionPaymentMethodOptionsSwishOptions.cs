// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionPaymentMethodOptionsSwishOptions : INestedOptions
    {
        /// <summary>
        /// The order reference that will be displayed to customers in the Swish application.
        /// Defaults to the <c>id</c> of the Payment Intent.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
