namespace Stripe
{
    public class StripePlan
    {
        [StripeArgument("id")]
        public string Id { get; set; }

        [StripeArgument("name")]
        public string Name { get; set; }

        [StripeArgument("currency")]
        public string Currency { get; set; }

        [StripeArgument("amount")]
        public int? AmountInCents { get; set; }

        [StripeArgument("interval")]
        public string Interval { get; set; }

        [StripeArgument("livemode")]
        public bool? LiveMode { get; set; }

        [StripeArgument("trial_period_days")]
        public int? TrialPeriodDays { get; set; }
    }
}