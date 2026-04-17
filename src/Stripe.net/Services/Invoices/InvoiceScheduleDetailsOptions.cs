// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceScheduleDetailsOptions : INestedOptions, IHasSetTracking
    {
        private List<InvoiceScheduleDetailsBillingScheduleOptions> billingSchedules;
        private List<InvoiceScheduleDetailsPrebillingOptions> prebilling;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Changes to apply to the phases of the subscription schedule, in the order provided.
        /// </summary>
        [JsonProperty("amendments")]
        [STJS.JsonPropertyName("amendments")]
        public List<InvoiceScheduleDetailsAmendmentOptions> Amendments { get; set; }

        /// <summary>
        /// Configures when the subscription schedule generates prorations for phase transitions.
        /// Possible values are <c>prorate_on_next_phase</c> or <c>prorate_up_front</c> with the
        /// default being <c>prorate_on_next_phase</c>. <c>prorate_on_next_phase</c> will apply
        /// phase changes and generate prorations at transition time. <c>prorate_up_front</c> will
        /// bill for all phases within the current billing cycle up front.
        /// One of: <c>prorate_on_next_phase</c>, or <c>prorate_up_front</c>.
        /// </summary>
        [JsonProperty("billing_behavior")]
        [STJS.JsonPropertyName("billing_behavior")]
        public string BillingBehavior { get; set; }

        /// <summary>
        /// Controls how prorations and invoices for subscriptions are calculated and orchestrated.
        /// </summary>
        [JsonProperty("billing_mode")]
        [STJS.JsonPropertyName("billing_mode")]
        public InvoiceScheduleDetailsBillingModeOptions BillingMode { get; set; }

        /// <summary>
        /// Sets the billing schedules for the subscription schedule.
        /// </summary>
        [JsonProperty("billing_schedules", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("billing_schedules")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<InvoiceScheduleDetailsBillingScheduleOptions> BillingSchedules
        {
            get => this.billingSchedules;
            set
            {
                this.billingSchedules = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Object representing the subscription schedule's default settings.
        /// </summary>
        [JsonProperty("default_settings")]
        [STJS.JsonPropertyName("default_settings")]
        public InvoiceScheduleDetailsDefaultSettingsOptions DefaultSettings { get; set; }

        /// <summary>
        /// Behavior of the subscription schedule and underlying subscription when it ends. Possible
        /// values are <c>release</c> or <c>cancel</c> with the default being <c>release</c>.
        /// <c>release</c> will end the subscription schedule and keep the underlying subscription
        /// running. <c>cancel</c> will end the subscription schedule and cancel the underlying
        /// subscription.
        /// One of: <c>cancel</c>, or <c>release</c>.
        /// </summary>
        [JsonProperty("end_behavior")]
        [STJS.JsonPropertyName("end_behavior")]
        public string EndBehavior { get; set; }

        /// <summary>
        /// List representing phases of the subscription schedule. Each phase can be customized to
        /// have different durations, plans, and coupons. If there are multiple phases, the
        /// <c>end_date</c> of one phase will always equal the <c>start_date</c> of the next phase.
        /// </summary>
        [JsonProperty("phases")]
        [STJS.JsonPropertyName("phases")]
        public List<InvoiceScheduleDetailsPhaseOptions> Phases { get; set; }

        /// <summary>
        /// Provide any time periods to bill in advance.
        /// </summary>
        [JsonProperty("prebilling", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("prebilling")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<InvoiceScheduleDetailsPrebillingOptions> Prebilling
        {
            get => this.prebilling;
            set
            {
                this.prebilling = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// In cases where the <c>schedule_details</c> params update the currently active phase,
        /// specifies if and how to prorate at the time of the request.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        [STJS.JsonPropertyName("proration_behavior")]
        public string ProrationBehavior { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
