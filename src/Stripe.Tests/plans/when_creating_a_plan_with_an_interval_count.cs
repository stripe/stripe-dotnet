using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_plan_with_an_interval_count
    {
        protected static StripePlanCreateOptions StripePlanCreateOptions;
        protected static StripePlan StripePlan;

        private static StripePlanService _stripePlanService;

        Establish context = () =>
        {
            _stripePlanService = new StripePlanService();
            StripePlanCreateOptions = test_data.stripe_plan_create_options.Valid();
            StripePlanCreateOptions.IntervalCount = 2;
        };

        Because of = () =>
            StripePlan = _stripePlanService.Create(StripePlanCreateOptions);

        It should_have_the_correct_interval_count = () =>
            StripePlan.IntervalCount.ShouldEqual(StripePlanCreateOptions.IntervalCount.Value);
    }
}