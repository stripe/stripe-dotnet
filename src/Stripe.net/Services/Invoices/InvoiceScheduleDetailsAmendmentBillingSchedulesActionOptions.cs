// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceScheduleDetailsAmendmentBillingSchedulesActionOptions : INestedOptions
    {
        /// <summary>
        /// Specify which subscription items the billing schedule applies to.
        /// </summary>
        [JsonProperty("applies_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applies_to")]
#endif
        public List<InvoiceScheduleDetailsAmendmentBillingSchedulesActionAppliesToOptions> AppliesTo { get; set; }

        /// <summary>
        /// Select the action.
        /// One of: <c>remove</c>, or <c>set</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
