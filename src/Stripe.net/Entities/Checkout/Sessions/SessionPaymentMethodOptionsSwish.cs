// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsSwish : StripeEntity<SessionPaymentMethodOptionsSwish>
    {
        /// <summary>
        /// The order reference that will be displayed to customers in the Swish application.
        /// Defaults to the <c>id</c> of the Payment Intent.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
