// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateActionAddTermAdHocProductBillScheduleCustomOptions : INestedOptions
    {
        /// <summary>
        /// Non-negative amount with an explicit currency that must match the contract's currency.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// A finite bill date. Resolved once per request, including on idempotent retries.
        /// </summary>
        [JsonProperty("bill_at")]
        [STJS.JsonPropertyName("bill_at")]
        public ContractUpdateActionAddTermAdHocProductBillScheduleCustomBillAtOptions BillAt { get; set; }
    }
}
