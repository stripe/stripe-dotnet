// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceScheduleDetailsBillingScheduleOptions : INestedOptions
    {
        /// <summary>
        /// Configure billing schedule differently for individual subscription items.
        /// </summary>
        [JsonProperty("applies_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applies_to")]
#endif
        public List<InvoiceScheduleDetailsBillingScheduleAppliesToOptions> AppliesTo { get; set; }

        /// <summary>
        /// The end date for the billing schedule.
        /// </summary>
        [JsonProperty("bill_until")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill_until")]
#endif
        public InvoiceScheduleDetailsBillingScheduleBillUntilOptions BillUntil { get; set; }

        /// <summary>
        /// Specify a key for the billing schedule. Must be unique to this field, alphanumeric, and
        /// up to 200 characters. If not provided, a unique key will be generated.
        /// </summary>
        [JsonProperty("key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("key")]
#endif
        public string Key { get; set; }
    }
}
