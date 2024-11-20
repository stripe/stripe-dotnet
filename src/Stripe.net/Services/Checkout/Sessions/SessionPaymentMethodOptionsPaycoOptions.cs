// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsPaycoOptions : INestedOptions
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }
    }
}
