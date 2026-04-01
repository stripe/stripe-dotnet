// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedTokenPaymentMethodDetailsNaverPay : StripeEntity<GrantedTokenPaymentMethodDetailsNaverPay>
    {
        /// <summary>
        /// Uniquely identifies this particular Naver Pay account. You can use this attribute to
        /// check whether two Naver Pay accounts are the same.
        /// </summary>
        [JsonProperty("buyer_id")]
        [STJS.JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// Whether to fund this transaction with Naver Pay points or a card.
        /// One of: <c>card</c>, or <c>points</c>.
        /// </summary>
        [JsonProperty("funding")]
        [STJS.JsonPropertyName("funding")]
        public string Funding { get; set; }
    }
}
