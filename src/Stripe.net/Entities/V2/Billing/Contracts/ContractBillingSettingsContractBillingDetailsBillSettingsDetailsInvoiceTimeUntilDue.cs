// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractBillingSettingsContractBillingDetailsBillSettingsDetailsInvoiceTimeUntilDue : StripeEntity<ContractBillingSettingsContractBillingDetailsBillSettingsDetailsInvoiceTimeUntilDue>
    {
        /// <summary>
        /// The interval unit.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        [STJS.JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals.
        /// </summary>
        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long IntervalCount { get; set; }
    }
}
