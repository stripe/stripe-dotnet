namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePhase : StripeEntity<SubscriptionSchedulePhase>
    {
        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice subtotal that will be transferred
        /// to the application owner’s Stripe account during this phase of the schedule.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        #region Expandable Coupon

        /// <summary>
        /// ID of the <see cref="Coupon"/> associated with this phase for the subscription schedule.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string CouponId { get; set; }

        /// <summary>
        /// (Expanded) The <see cref="Coupon"/> associated with this phase for the subscription
        /// schedule.
        /// </summary>
        [JsonIgnore]
        public Coupon Coupon { get; set; }

        [JsonProperty("coupon")]
        internal object InternalCoupon
        {
            get
            {
                return this.Coupon ?? (object)this.CouponId;
            }

            set
            {
                StringOrObject<Coupon>.Map(value, s => this.CouponId = s, o => this.Coupon = o);
            }
        }
        #endregion

        /// <summary>
        /// The end of this phase of the subscription schedule.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Plans to subscribe during this phase of the subscription schedule.
        /// </summary>
        [JsonProperty("plans")]
        public List<SubscriptionSchedulePhaseItem> Plans { get; set; }

        /// <summary>
        /// The start of this phase of the subscription schedule.
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// If provided, each invoice created during this phase of the subscription schedule will
        /// apply the tax rate, increasing the amount billed to the customer.
        /// </summary>
        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        /// <summary>
        /// When the trial ends within the phase.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? TrialEnd { get; set; }
    }
}
