// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractOneTimeFeesDataBillSchedule : StripeEntity<ContractOneTimeFeesDataBillSchedule>
    {
        /// <summary>
        /// When this entry will be billed.
        /// </summary>
        [JsonProperty("bill_at")]
        [STJS.JsonPropertyName("bill_at")]
        public ContractOneTimeFeesDataBillScheduleBillAt BillAt { get; set; }

        /// <summary>
        /// The amount to bill for this entry, in the smallest currency unit.
        /// </summary>
        [JsonProperty("value")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("value")]
        public long Value { get; set; }
    }
}
