// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodDataKrMarketOptions : INestedOptions
    {
        /// <summary>
        /// Underlying payment method that the buyer selected.
        /// One of: <c>bc</c>, <c>citi</c>, <c>hana</c>, <c>hyundai</c>, <c>jeju</c>,
        /// <c>jeonbuk</c>, <c>kakaobank</c>, <c>kakaopay</c>, <c>kbank</c>, <c>kdbbank</c>,
        /// <c>kookmin</c>, <c>kwangju</c>, <c>lotte</c>, <c>mg</c>, <c>naverpaycard</c>,
        /// <c>naverpaypoint</c>, <c>nh</c>, <c>payco</c>, <c>post</c>, <c>samsung</c>,
        /// <c>samsungpay</c>, <c>savingsbank</c>, <c>shinhan</c>, <c>shinhyup</c>, <c>suhyup</c>,
        /// <c>tossbank</c>, or <c>woori</c>.
        /// </summary>
        [JsonProperty("underlying_payment_method")]
        public string UnderlyingPaymentMethod { get; set; }
    }
}
