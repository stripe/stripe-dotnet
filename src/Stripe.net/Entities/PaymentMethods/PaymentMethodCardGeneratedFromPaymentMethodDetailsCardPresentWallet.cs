// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresentWallet : StripeEntity<PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresentWallet>
    {
        /// <summary>
        /// The type of mobile wallet, one of <c>apple_pay</c>, <c>google_pay</c>,
        /// <c>samsung_pay</c>, or <c>unknown</c>.
        /// One of: <c>apple_pay</c>, <c>google_pay</c>, <c>samsung_pay</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
