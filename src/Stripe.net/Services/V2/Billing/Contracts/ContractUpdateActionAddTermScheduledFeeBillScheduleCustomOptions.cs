// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateActionAddTermScheduledFeeBillScheduleCustomOptions : INestedOptions
    {
        /// <summary>
        /// A finite bill date. Resolved once per request, including on idempotent retries.
        /// </summary>
        [JsonProperty("bill_at")]
        [STJS.JsonPropertyName("bill_at")]
        public ContractUpdateActionAddTermScheduledFeeBillScheduleCustomBillAtOptions BillAt { get; set; }

        /// <summary>
        /// Positive installment quantity. Defaults to 1 when omitted.
        /// </summary>
        [JsonProperty("quantity")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Positive unit price in minor units of the contract's currency, before multiplying by
        /// quantity.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
