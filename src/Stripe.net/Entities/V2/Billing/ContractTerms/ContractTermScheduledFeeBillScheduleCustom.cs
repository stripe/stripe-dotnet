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
        /// Amount in the contract's currency.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// The resolved bill date.
        /// </summary>
        [JsonProperty("bill_at")]
        [STJS.JsonPropertyName("bill_at")]
        public ContractTermScheduledFeeBillScheduleCustomBillAt BillAt { get; set; }
    }
}
