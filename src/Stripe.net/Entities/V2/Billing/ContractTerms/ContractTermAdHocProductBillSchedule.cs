// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractTermAdHocProductBillSchedule : StripeEntity<ContractTermAdHocProductBillSchedule>
    {
        /// <summary>
        /// Scheduled installments and billed history.
        /// </summary>
        [JsonProperty("custom")]
        [STJS.JsonPropertyName("custom")]
        public List<ContractTermAdHocProductBillScheduleCustom> Custom { get; set; }

        /// <summary>
        /// The type of billing schedule.
        /// One of: <c>custom</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
