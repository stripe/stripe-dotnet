// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceUpcomingLinesScheduleDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Changes to apply to the phases of the subscription schedule, in the order provided.
        /// </summary>
        [JsonProperty("amendments")]
        public List<InvoiceUpcomingLinesScheduleDetailsAmendmentOptions> Amendments { get; set; }

        /// <summary>
        /// Configures when the subscription schedule generates prorations for phase transitions.
        /// Possible values are <c>prorate_on_next_phase</c> or <c>prorate_up_front</c> with the
        /// default being <c>prorate_on_next_phase</c>. <c>prorate_on_next_phase</c> will apply
        /// phase changes and generate prorations at transition time. <c>prorate_up_front</c> will
        /// bill for all phases within the current billing cycle up front.
        /// One of: <c>prorate_on_next_phase</c>, or <c>prorate_up_front</c>.
        /// </summary>
        [JsonProperty("billing_behavior")]
        public string BillingBehavior { get; set; }

        /// <summary>
        /// Behavior of the subscription schedule and underlying subscription when it ends. Possible
        /// values are <c>release</c> or <c>cancel</c> with the default being <c>release</c>.
        /// <c>release</c> will end the subscription schedule and keep the underlying subscription
        /// running. <c>cancel</c> will end the subscription schedule and cancel the underlying
        /// subscription.
        /// One of: <c>cancel</c>, or <c>release</c>.
        /// </summary>
        [JsonProperty("end_behavior")]
        public string EndBehavior { get; set; }

        /// <summary>
        /// List representing phases of the subscription schedule. Each phase can be customized to
        /// have different durations, plans, and coupons. If there are multiple phases, the
        /// <c>end_date</c> of one phase will always equal the <c>start_date</c> of the next phase.
        /// </summary>
        [JsonProperty("phases")]
        public List<InvoiceUpcomingLinesScheduleDetailsPhaseOptions> Phases { get; set; }

        /// <summary>
        /// Provide any time periods to bill in advance.
        /// </summary>
        [JsonProperty("prebilling")]
        public List<InvoiceUpcomingLinesScheduleDetailsPrebillingOptions> Prebilling { get; set; }

        /// <summary>
        /// In cases where the <c>schedule_details</c> params update the currently active phase,
        /// specifies if and how to prorate at the time of the request.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }
    }
}
