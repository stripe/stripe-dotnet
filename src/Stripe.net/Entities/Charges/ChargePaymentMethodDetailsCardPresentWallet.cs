// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsCardPresentWallet : StripeEntity<ChargePaymentMethodDetailsCardPresentWallet>
    {
        /// <summary>
        /// The type of mobile wallet, one of <c>apple_pay</c>, <c>google_pay</c>,
        /// <c>samsung_pay</c>, or <c>unknown</c>.
        /// One of: <c>apple_pay</c>, <c>google_pay</c>, <c>samsung_pay</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
