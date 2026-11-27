// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractTermScheduledFeeBillScheduleCustom : StripeEntity<ContractTermScheduledFeeBillScheduleCustom>
    {
        /// <summary>
        /// The resolved bill date.
        /// </summary>
        [JsonProperty("bill_at")]
        [STJS.JsonPropertyName("bill_at")]
        public ContractTermScheduledFeeBillScheduleCustomBillAt BillAt { get; set; }

        /// <summary>
        /// Resolved installment quantity. Always present; defaults to 1 when omitted on input.
        /// </summary>
        [JsonProperty("quantity")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Unit price in minor units of the contract's currency, before multiplying by quantity.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("unit_amount_decimal")]
        public decimal UnitAmountDecimal { get; set; }
    }
}
