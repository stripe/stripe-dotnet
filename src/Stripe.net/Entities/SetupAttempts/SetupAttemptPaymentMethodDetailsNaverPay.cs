// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupAttemptPaymentMethodDetailsNaverPay : StripeEntity<SetupAttemptPaymentMethodDetailsNaverPay>
    {
        /// <summary>
        /// Uniquely identifies this particular Naver Pay account. You can use this attribute to
        /// check whether two Naver Pay accounts are the same.
        /// </summary>
        [JsonProperty("buyer_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("buyer_id")]
#endif
        public string BuyerId { get; set; }
    }
}
