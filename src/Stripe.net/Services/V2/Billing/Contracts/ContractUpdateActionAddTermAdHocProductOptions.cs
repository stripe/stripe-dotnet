// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateActionAddTermAdHocProductOptions : INestedOptions
    {
        /// <summary>
        /// Explicit bill dates and amounts.
        /// </summary>
        [JsonProperty("bill_schedule")]
        [STJS.JsonPropertyName("bill_schedule")]
        public ContractUpdateActionAddTermAdHocProductBillScheduleOptions BillSchedule { get; set; }

        /// <summary>
        /// The V1 Product being billed.
        /// </summary>
        [JsonProperty("product")]
        [STJS.JsonPropertyName("product")]
        public string Product { get; set; }

        /// <summary>
        /// Informational service period, independent of bill dates.
        /// </summary>
        [JsonProperty("service_period")]
        [STJS.JsonPropertyName("service_period")]
        public ContractUpdateActionAddTermAdHocProductServicePeriodOptions ServicePeriod { get; set; }
    }
}
