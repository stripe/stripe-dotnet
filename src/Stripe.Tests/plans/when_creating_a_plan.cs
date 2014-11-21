using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_plan
    {
        protected static StripePlanCreateOptions StripePlanCreateOptions;
        protected static StripePlan StripePlan;

        private static StripePlanService _stripePlanService;

        Establish context = () =>
        {
            _stripePlanService = new StripePlanService();
            StripePlanCreateOptions = test_data.stripe_plan_create_options.Valid();
        };

        Because of = () =>
            StripePlan = _stripePlanService.Create(StripePlanCreateOptions);

        Behaves_like<plan_behaviors> behaviors;

        It should_have_metadata = () =>
            StripePlan.Metadata.Count.ShouldBeGreaterThan(0);

        It should_have_correct_metadata = () =>
            StripePlan.Metadata.ShouldContainOnly(StripePlanCreateOptions.Metadata);
    }
}