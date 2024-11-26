// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodPreviewNaverPay : StripeEntity<ConfirmationTokenPaymentMethodPreviewNaverPay>
    {
        /// <summary>
        /// Whether to fund this transaction with Naver Pay points or a card.
        /// One of: <c>card</c>, or <c>points</c>.
        /// </summary>
        [JsonProperty("funding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("funding")]
#endif
        public string Funding { get; set; }
    }
}
