// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionCurrentAttemptPaymentMethodDetailsCardWallet : StripeEntity<SessionCurrentAttemptPaymentMethodDetailsCardWallet>
    {
        /// <summary>
        /// The type of the wallet, one of <c>amex_express_checkout</c>, <c>apple_pay</c>,
        /// <c>google_pay</c>, <c>masterpass</c>, <c>samsung_pay</c>, <c>visa_checkout</c>,
        /// <c>meta_pay</c>, or <c>link</c>.
        /// One of: <c>amex_express_checkout</c>, <c>apple_pay</c>, <c>google_pay</c>, <c>link</c>,
        /// <c>masterpass</c>, <c>meta_pay</c>, <c>samsung_pay</c>, or <c>visa_checkout</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
