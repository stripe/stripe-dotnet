// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceScheduleDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Changes to apply to the phases of the subscription schedule, in the order provided.
        /// </summary>
        [JsonProperty("amendments")]
        public List<InvoiceScheduleDetailsAmendmentOptions> Amendments { get; set; }

        /// <summary>
        /// List representing phases of the subscription schedule. Each phase can be customized to
        /// have different durations, plans, and coupons. If there are multiple phases, the
        /// <c>end_date</c> of one phase will always equal the <c>start_date</c> of the next phase.
        /// </summary>
        [JsonProperty("phases")]
        public List<InvoiceScheduleDetailsPhaseOptions> Phases { get; set; }

        /// <summary>
        /// Provide any time periods to bill in advance.
        /// </summary>
        [JsonProperty("prebilling")]
        public List<InvoiceScheduleDetailsPrebillingOptions> Prebilling { get; set; }
    }
}
