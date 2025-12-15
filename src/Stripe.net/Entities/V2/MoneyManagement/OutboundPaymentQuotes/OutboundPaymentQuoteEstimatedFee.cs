// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentQuoteEstimatedFee : StripeEntity<OutboundPaymentQuoteEstimatedFee>
    {
        /// <summary>
        /// The fee amount for corresponding fee type.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public OutboundPaymentQuoteEstimatedFeeAmount Amount { get; set; }

        /// <summary>
        /// The fee type.
        /// One of: <c>cross_border_payout_fee</c>, <c>foreign_exchange_fee</c>,
        /// <c>instant_payout_fee</c>, <c>standard_payout_fee</c>, or <c>wire_payout_fee</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
