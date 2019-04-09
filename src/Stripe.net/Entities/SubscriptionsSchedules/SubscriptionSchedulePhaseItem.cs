namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePhaseItem : StripeEntity
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
        public string PlanId { get; set; }

        /// <summary>
        /// (Expanded) The <see cref="Plan"/> included in the phase for this subscription schedule.
        /// </summary>
        [JsonIgnore]
        public Plan Plan { get; set; }

        [JsonProperty("plan")]
        internal object InternalPlan
        {
            get
            {
                return this.Plan ?? (object)this.PlanId;
            }

            set
            {
                StringOrObject<Plan>.Map(value, s => this.PlanId = s, o => this.Plan = o);
            }
        }
        #endregion

        /// <summary>
        /// Quantity of the plan to which the customer should be subscribed.
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to this specific item on the phase for a subscription
        /// schedule.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<TaxRate> TaxRates { get; set; }
    }
}
