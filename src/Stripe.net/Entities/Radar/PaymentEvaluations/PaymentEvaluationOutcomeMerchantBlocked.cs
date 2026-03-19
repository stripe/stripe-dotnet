// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentEvaluationOutcomeMerchantBlocked : StripeEntity<PaymentEvaluationOutcomeMerchantBlocked>
    {
        /// <summary>
        /// The reason the payment was blocked by the merchant.
        /// One of: <c>authentication_required</c>, <c>blocked_for_fraud</c>,
        /// <c>invalid_payment</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
