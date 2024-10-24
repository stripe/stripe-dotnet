// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodNaverPay : StripeEntity<PaymentMethodNaverPay>
    {
        /// <summary>
        /// Whether to fund this transaction with Naver Pay points or a card.
        /// One of: <c>card</c>, or <c>points</c>.
        /// </summary>
        [JsonProperty("funding")]
        public string Funding { get; set; }
    }
}
