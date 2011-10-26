using System;

namespace Stripe
{
    public class StripeSubscription
    {
        [StripeArgument("customer")]
        public string CustomerId { get; set; }

        [StripeArgument("current_period_start")]
        public DateTime? PeriodStart { get; set; }

        [StripeArgument("current_period_end")]
        public DateTime? PeriodEnd { get; set; }

        [StripeArgument("start")]
        public DateTime? Start { get; set; }

        [StripeArgument("status")]
        public string Status { get; set; }

        [StripeArgument("trial_start")]
        public DateTime? TrialStart { get; set; }

        [StripeArgument("trial_end")]
        public DateTime? TrialEnd { get; set; }

        [StripeArgument("canceled_at")]
        public DateTime? CanceledAt { get; set; }

        [StripeArgument("ended_at")]
        public DateTime? EndedAt { get; set; }

        public StripePlan StripePlan { get; set; }
    }
}