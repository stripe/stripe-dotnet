// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteSubscriptionDataOverrideOptions : INestedOptions
    {
        /// <summary>
        /// Whether the override applies to an existing Subscription Schedule or a new Subscription
        /// Schedule.
        /// </summary>
        [JsonProperty("applies_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applies_to")]
#endif
        public QuoteSubscriptionDataOverrideAppliesToOptions AppliesTo { get; set; }

        /// <summary>
        /// Describes the period to bill for upon accepting the quote.
        /// </summary>
        [JsonProperty("bill_on_acceptance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill_on_acceptance")]
#endif
        public QuoteSubscriptionDataOverrideBillOnAcceptanceOptions BillOnAcceptance { get; set; }

        /// <summary>
        /// Configures when the subscription schedule generates prorations for phase transitions.
        /// Possible values are <c>prorate_on_next_phase</c> or <c>prorate_up_front</c> with the
        /// default being <c>prorate_on_next_phase</c>. <c>prorate_on_next_phase</c> will apply
        /// phase changes and generate prorations at transition time. <c>prorate_up_front</c> will
        /// bill for all phases within the current billing cycle up front.
        /// One of: <c>prorate_on_next_phase</c>, or <c>prorate_up_front</c>.
        /// </summary>
        [JsonProperty("billing_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_behavior")]
#endif
        public string BillingBehavior { get; set; }

        /// <summary>
        /// Billing schedules that will be applied to the subscription or subscription schedule
        /// created when the quote is accepted.
        /// </summary>
        [JsonProperty("billing_schedules")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_schedules")]
#endif
        public List<QuoteSubscriptionDataOverrideBillingScheduleOptions> BillingSchedules { get; set; }

        /// <summary>
        /// The customer the Subscription Data override applies to. This is only relevant when
        /// <c>applies_to.type=new_reference</c>.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// The subscription's description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription for rendering in Stripe surfaces
        /// and certain local payment methods UIs.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Behavior of the subscription schedule and underlying subscription when it ends.
        /// One of: <c>cancel</c>, or <c>release</c>.
        /// </summary>
        [JsonProperty("end_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_behavior")]
#endif
        public string EndBehavior { get; set; }

        /// <summary>
        /// Configures how the subscription schedule handles billing for phase transitions when the
        /// quote is accepted. Possible values are <c>phase_start</c> (default) or
        /// <c>billing_period_start</c>. <c>phase_start</c> bills based on the current state of the
        /// subscription, ignoring changes scheduled in future phases. <c>billing_period_start</c>
        /// bills predictively for upcoming phase transitions within the current billing cycle,
        /// including pricing changes and service period adjustments that will occur before the next
        /// invoice.
        /// One of: <c>billing_period_start</c>, or <c>line_start</c>.
        /// </summary>
        [JsonProperty("phase_effective_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phase_effective_at")]
#endif
        public string PhaseEffectiveAt { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://docs.stripe.com/subscriptions/billing-cycle#prorations">prorations</a>.
        /// When creating a subscription, valid values are <c>create_prorations</c> or <c>none</c>.
        ///
        /// When updating a subscription, valid values are <c>create_prorations</c>, <c>none</c>, or
        /// <c>always_invoice</c>.
        ///
        /// Passing <c>create_prorations</c> will cause proration invoice items to be created when
        /// applicable. These proration items will only be invoiced immediately under <a
        /// href="https://docs.stripe.com/subscriptions/upgrading-downgrading#immediate-payment">certain
        /// conditions</a>. In order to always invoice immediately for prorations, pass
        /// <c>always_invoice</c>.
        ///
        /// Prorations can be disabled by passing <c>none</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_behavior")]
#endif
        public string ProrationBehavior { get; set; }
    }
}
