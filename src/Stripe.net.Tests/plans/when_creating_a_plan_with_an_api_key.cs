using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_plan_with_an_api_key
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

#pragma warning disable 169, 414
        Behaves_like<plan_behaviors> behaviors;
#pragma warning restore 169, 414

    }
}
