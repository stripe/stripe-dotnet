using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class plan_behaviors
    {
        protected static StripePlanCreateOptions StripePlanCreateOptions;
        protected static StripePlan StripePlan;
    
        It should_have_the_correct_id = () =>
            StripePlan.Id.ShouldEqual(StripePlanCreateOptions.Id);

        It should_have_the_correct_amount = () =>
            StripePlan.Amount.ShouldEqual(StripePlanCreateOptions.Amount);

        It should_have_the_correct_currency = () =>
            StripePlan.Currency.ShouldEqual(StripePlanCreateOptions.Currency);

        It should_have_the_correct_interval = () =>
            StripePlan.Interval.ShouldEqual(StripePlanCreateOptions.Interval);
        
        It should_have_the_correct_interval_count = () =>
            StripePlan.IntervalCount.ShouldEqual(1);

        It should_have_the_correct_name = () =>
            StripePlan.Name.ShouldEqual(StripePlanCreateOptions.Name);

        It should_have_the_correct_trial_period_days = () =>
            StripePlan.TrialPeriodDays.ShouldEqual(StripePlanCreateOptions.TrialPeriodDays);

        It should_have_a_created_date = () =>
            StripePlan.Created.ShouldNotBeNull();

        It should_have_the_correct_statement_descriptor = () =>
            StripePlan.StatementDescriptor.ShouldEqual(StripePlanCreateOptions.StatementDescriptor);

        It should_have_the_correct_live_mode = () =>
            StripePlan.LiveMode.ShouldEqual(false);
    }
}