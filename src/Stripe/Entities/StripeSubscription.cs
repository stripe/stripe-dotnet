using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using Newtonsoft.Json.Linq;

namespace Stripe
{
    public class StripeSubscription : StripeObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("cancel_at_period_end")]
        public bool CancelAtPeriodEnd { get; set; }

        #region Expandable Customer
        public string CustomerId { get; set; }

        [JsonIgnore]
        public StripeCustomer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            set
            {
                ExpandableProperty<StripeCustomer>.Map(value, s => CustomerId = s, o => Customer = o);
            }
        }
        #endregion

        [JsonProperty("plan")]
        public StripePlan StripePlan { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("start")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Start { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        [JsonProperty("current_period_end")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? PeriodEnd { get; set; }

        [JsonProperty("current_period_start")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? PeriodStart { get; set; }

        [JsonProperty("discount")]
        public StripeDiscount StripeDiscount { get; set; }

        [JsonProperty("ended_at")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? EndedAt { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("trial_end")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }

        [JsonProperty("trial_start")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? TrialStart { get; set; }
    }
}