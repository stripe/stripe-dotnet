// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodKrCard : StripeEntity<PaymentMethodKrCard>
    {
        /// <summary>
        /// The local credit or debit card brand.
        /// One of: <c>bc</c>, <c>citi</c>, <c>hana</c>, <c>hyundai</c>, <c>jeju</c>,
        /// <c>jeonbuk</c>, <c>kakaobank</c>, <c>kbank</c>, <c>kdbbank</c>, <c>kookmin</c>,
        /// <c>kwangju</c>, <c>lotte</c>, <c>mg</c>, <c>nh</c>, <c>post</c>, <c>samsung</c>,
        /// <c>savingsbank</c>, <c>shinhan</c>, <c>shinhyup</c>, <c>suhyup</c>, <c>tossbank</c>, or
        /// <c>woori</c>.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The last four digits of the card. This may not be present for American Express cards.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }
    }
}
