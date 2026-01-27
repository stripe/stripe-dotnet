// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationOutcomeMerchantBlocked : StripeEntity<PaymentEvaluationOutcomeMerchantBlocked>
    {
        /// <summary>
        /// The reason the payment was blocked by the merchant.
        /// One of: <c>authentication_required</c>, <c>blocked_for_fraud</c>,
        /// <c>invalid_payment</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
