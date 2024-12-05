// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionPaymentMethodOptionsSwish : StripeEntity<SessionPaymentMethodOptionsSwish>
    {
        /// <summary>
        /// The order reference that will be displayed to customers in the Swish application.
        /// Defaults to the <c>id</c> of the Payment Intent.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }
    }
}
