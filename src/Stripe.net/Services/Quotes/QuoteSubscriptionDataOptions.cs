// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteSubscriptionDataOptions : INestedOptions
    {
        /// <summary>
        /// Describes the period to bill for upon accepting the quote.
        /// </summary>
        [JsonProperty("bill_on_acceptance")]
        public QuoteSubscriptionDataBillOnAcceptanceOptions BillOnAcceptance { get; set; }

        /// <summary>
        /// Configures when the subscription schedule generates prorations for phase transitions.
        /// Possible values are <c>prorate_on_next_phase</c> or <c>prorate_up_front</c> with the
        /// default being <c>prorate_on_next_phase</c>. <c>prorate_on_next_phase</c> will apply
        /// phase changes and generate prorations at transition time.<c>prorate_up_front</c> will
        /// bill for all phases within the current billing cycle up front.
        /// One of: <c>prorate_on_next_phase</c>, or <c>prorate_up_front</c>.
        /// </summary>
        [JsonProperty("billing_behavior")]
        public string BillingBehavior { get; set; }

        /// <summary>
        /// When specified as <c>reset</c>, the subscription will always start a new billing period
        /// when the quote is accepted.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// The subscription's description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription for rendering in Stripe surfaces
        /// and certain local payment methods UIs.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// When creating a new subscription, the date of which the subscription schedule will start
        /// after the quote is accepted. When updating a subscription, the date of which the
        /// subscription will be updated using a subscription schedule. The special value
        /// <c>current_period_end</c> can be provided to update a subscription at the end of its
        /// current period. The <c>effective_date</c> is ignored if it is in the past when the quote
        /// is accepted.
        /// </summary>
        [JsonProperty("effective_date")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, QuoteSubscriptionDataEffectiveDate> EffectiveDate { get; set; }

        /// <summary>
        /// Behavior of the subscription schedule and underlying subscription when it ends.
        /// One of: <c>cancel</c>, or <c>release</c>.
        /// </summary>
        [JsonProperty("end_behavior")]
        public string EndBehavior { get; set; }

        /// <summary>
        /// The id of a subscription schedule the quote will update. The quote will inherit the
        /// state of the subscription schedule, such as <c>phases</c>. Cannot be combined with other
        /// parameters.
        /// </summary>
        [JsonProperty("from_schedule")]
        public string FromSchedule { get; set; }

        /// <summary>
        /// The id of a subscription that the quote will update. By default, the quote will contain
        /// the state of the subscription (such as line items, collection method and billing
        /// thresholds) unless overridden.
        /// </summary>
        [JsonProperty("from_subscription")]
        public string FromSubscription { get; set; }

        /// <summary>
        /// If specified, the invoicing for the given billing cycle iterations will be processed
        /// when the quote is accepted. Cannot be used with <c>effective_date</c>.
        /// </summary>
        [JsonProperty("prebilling")]
        public QuoteSubscriptionDataPrebillingOptions Prebilling { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://stripe.com/docs/subscriptions/billing-cycle#prorations">prorations</a>.
        /// When creating a subscription, valid values are <c>create_prorations</c> or <c>none</c>.
        ///
        /// When updating a subscription, valid values are <c>create_prorations</c>, <c>none</c>, or
        /// <c>always_invoice</c>.
        ///
        /// Passing <c>create_prorations</c> will cause proration invoice items to be created when
        /// applicable. These proration items will only be invoiced immediately under <a
        /// href="https://stripe.com/docs/subscriptions/upgrading-downgrading#immediate-payment">certain
        /// conditions</a>. In order to always invoice immediately for prorations, pass
        /// <c>always_invoice</c>.
        ///
        /// Prorations can be disabled by passing <c>none</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
