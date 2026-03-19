// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionPaymentMethodOptionsAlma : StripeEntity<SessionPaymentMethodOptionsAlma>
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// </summary>
        [JsonProperty("capture_method")]
        [STJS.JsonPropertyName("capture_method")]
        public string CaptureMethod { get; set; }
    }
}
