// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentEstimatedFee : StripeEntity<PayoutIntentEstimatedFee>
    {
        /// <summary>
        /// The fee amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Tax charged for this fee, if applicable. Value expressed as a decimal string in major
        /// units.
        /// </summary>
        [JsonProperty("tax_amount")]
        [STJS.JsonPropertyName("tax_amount")]
        public PayoutIntentEstimatedFeeTaxAmount TaxAmount { get; set; }

        /// <summary>
        /// Open Enum. The type of fee.
        /// One of: <c>cross_border_fee</c>, <c>foreign_exchange_fee</c>,
        /// <c>instant_card_payout_fee</c>, <c>next_day_payout_fee</c>, <c>real_time_payout_fee</c>,
        /// <c>stablecoin_payout_fee</c>, <c>stablecoin_routing_fee</c>, <c>standard_payout_fee</c>,
        /// or <c>wire_payout_fee</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
