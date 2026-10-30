// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateActionUpdateTermAdHocProductBillScheduleOptions : INestedOptions
    {
        /// <summary>
        /// Full replacement of up to ten unbilled installments. An explicit empty array cancels all
        /// of them.
        /// </summary>
        [JsonProperty("custom")]
        [STJS.JsonPropertyName("custom")]
        public List<ContractUpdateActionUpdateTermAdHocProductBillScheduleCustomOptions> Custom { get; set; }

        /// <summary>
        /// The type of schedule.
        /// One of: <c>custom</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
