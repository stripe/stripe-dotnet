// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodDataOptions : INestedOptions
    {
        /// <summary>
        /// Allow redisplay will be set on the payment method on confirmation and indicates whether
        /// this payment method can be shown again to the customer in a checkout flow. Only set this
        /// field if you wish to override the allow_redisplay value determined by Checkout.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay")]
        public string AllowRedisplay { get; set; }
    }
}
