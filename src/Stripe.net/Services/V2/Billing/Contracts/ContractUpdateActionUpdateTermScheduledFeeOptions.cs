// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateActionUpdateTermScheduledFeeOptions : INestedOptions
    {
        /// <summary>
        /// Replace remaining unbilled installments. Billed entries remain immutable.
        /// </summary>
        [JsonProperty("bill_schedule")]
        [STJS.JsonPropertyName("bill_schedule")]
        public ContractUpdateActionUpdateTermScheduledFeeBillScheduleOptions BillSchedule { get; set; }

        /// <summary>
        /// Informational service period; cannot change historical billing.
        /// </summary>
        [JsonProperty("service_period")]
        [STJS.JsonPropertyName("service_period")]
        public ContractUpdateActionUpdateTermScheduledFeeServicePeriodOptions ServicePeriod { get; set; }
    }
}
