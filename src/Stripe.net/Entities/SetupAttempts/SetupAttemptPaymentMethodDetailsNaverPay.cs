// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupAttemptPaymentMethodDetailsNaverPay : StripeEntity<SetupAttemptPaymentMethodDetailsNaverPay>
    {
        /// <summary>
        /// Uniquely identifies this particular Naver Pay account. You can use this attribute to
        /// check whether two Naver Pay accounts are the same.
        /// </summary>
        [JsonProperty("buyer_id")]
        [STJS.JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }
    }
}
