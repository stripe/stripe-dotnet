// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceUpcomingLinesScheduleDetailsAmendmentOptions : INestedOptions
    {
        /// <summary>
        /// Details to identify the end of the time range modified by the proposed change. If not
        /// supplied, the amendment is considered a point-in-time operation that only affects the
        /// exact timestamp at <c>amendment_start</c>, and a restricted set of attributes is
        /// supported on the amendment.
        /// </summary>
        [JsonProperty("amendment_end")]
        public InvoiceUpcomingLinesScheduleDetailsAmendmentAmendmentEndOptions AmendmentEnd { get; set; }

        /// <summary>
        /// Details to identify the earliest timestamp where the proposed change should take effect.
        /// </summary>
        [JsonProperty("amendment_start")]
        public InvoiceUpcomingLinesScheduleDetailsAmendmentAmendmentStartOptions AmendmentStart { get; set; }

        /// <summary>
        /// For point-in-time amendments (having no <c>amendment_end</c>), this attribute lets you
        /// set or remove whether the subscription's billing cycle anchor is reset at the
        /// <c>amendment_start</c> timestamp.For time-span based amendments (having both
        /// <c>amendment_start</c> and <c>amendment_end</c>), the only value valid is
        /// <c>automatic</c>, which removes any previously configured billing cycle anchor resets
        /// scheduled to occur during the window of time spanned by the amendment.
        /// One of: <c>amendment_start</c>, or <c>automatic</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Changes to the coupons being redeemed or discounts being applied during the amendment
        /// time span.
        /// </summary>
        [JsonProperty("discount_actions")]
        public List<InvoiceUpcomingLinesScheduleDetailsAmendmentDiscountActionOptions> DiscountActions { get; set; }

        /// <summary>
        /// Changes to the subscription items during the amendment time span.
        /// </summary>
        [JsonProperty("item_actions")]
        public List<InvoiceUpcomingLinesScheduleDetailsAmendmentItemActionOptions> ItemActions { get; set; }

        /// <summary>
        /// Instructions for how to modify phase metadata.
        /// </summary>
        [JsonProperty("metadata_actions")]
        public List<InvoiceUpcomingLinesScheduleDetailsAmendmentMetadataActionOptions> MetadataActions { get; set; }

        /// <summary>
        /// Changes to how Stripe handles prorations during the amendment time span. Affects if and
        /// how prorations are created when a future phase starts. In cases where the amendment
        /// changes the currently active phase, it is used to determine whether or how to prorate
        /// now, at the time of the request. Also supported as a point-in-time operation when
        /// <c>amendment_end</c> is <c>null</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// Defines how to pause collection for the underlying subscription throughout the duration
        /// of the amendment.
        /// </summary>
        [JsonProperty("set_pause_collection")]
        public InvoiceUpcomingLinesScheduleDetailsAmendmentSetPauseCollectionOptions SetPauseCollection { get; set; }

        /// <summary>
        /// Ends the subscription schedule early as dictated by either the accompanying amendment's
        /// start or end.
        /// One of: <c>amendment_end</c>, or <c>amendment_start</c>.
        /// </summary>
        [JsonProperty("set_schedule_end")]
        public string SetScheduleEnd { get; set; }

        /// <summary>
        /// Settings related to subscription trials.
        /// </summary>
        [JsonProperty("trial_settings")]
        public InvoiceUpcomingLinesScheduleDetailsAmendmentTrialSettingsOptions TrialSettings { get; set; }
    }
}
