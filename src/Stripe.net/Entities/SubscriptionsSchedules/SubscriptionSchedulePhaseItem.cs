namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePhaseItem : StripeEntity<SubscriptionSchedulePhaseItem>
    {
        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period.
        /// </summary>
        [JsonProperty("billing_thresholds")]
        public SubscriptionItemBillingThresholds BillingThresholds { get; set; }

        #region Expandable Plan

        /// <summary>
        /// ID of the <see cref="Plan"/> included in the phase for this subscription schedule.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string PlanId => this.InternalPlan.Id;

        /// <summary>
        /// (Expanded) The <see cref="Plan"/> included in the phase for this subscription schedule.
        /// </summary>
        [JsonIgnore]
        public Plan Plan => this.InternalPlan.ExpandedObject;

        [JsonProperty("plan")]
        [JsonConverter(typeof(ExpandableFieldConverter<Plan>))]
        internal ExpandableField<Plan> InternalPlan { get; set; }
        #endregion

        /// <summary>
        /// Quantity of the plan to which the customer should be subscribed.
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }
    }
}
