// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodDataNaverPayOptions : INestedOptions
    {
        /// <summary>
        /// Whether to use Naver Pay points or a card to fund this transaction. If not provided,
        /// this defaults to <c>card</c>.
        /// One of: <c>card</c>, or <c>points</c>.
        /// </summary>
        [JsonProperty("funding")]
        [STJS.JsonPropertyName("funding")]
        public string Funding { get; set; }
    }
}
