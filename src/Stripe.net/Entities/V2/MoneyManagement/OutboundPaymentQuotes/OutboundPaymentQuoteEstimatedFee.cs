// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentQuoteEstimatedFee : StripeEntity<OutboundPaymentQuoteEstimatedFee>
    {
        /// <summary>
        /// The fee amount for corresponding fee type.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// The fee type.
        /// One of: <c>cross_border_payout_fee</c>, <c>foreign_exchange_fee</c>,
        /// <c>instant_payout_fee</c>, <c>real_time_payout_fee</c>, <c>standard_payout_fee</c>, or
        /// <c>wire_payout_fee</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
