using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_updating_a_plan
    {
        protected static StripePlanCreateOptions StripePlanCreateOptions;
        protected static StripePlanUpdateOptions StripePlanUpdateOptions;
        protected static StripePlan CreatedPlan;
        protected static StripePlan StripePlan;

        private static StripePlanService _stripePlanService;

        Establish context = () =>
        {
            _stripePlanService = new StripePlanService();
            StripePlanCreateOptions = test_data.stripe_plan_create_options.Valid();
            StripePlanUpdateOptions = test_data.stripe_plan_update_options.Valid();
            StripePlanUpdateOptions.Id = StripePlanCreateOptions.Id;
            
        };

        private Because of = () =>
                                 {
                                     CreatedPlan = _stripePlanService.Create(StripePlanCreateOptions);

                                     StripePlan = _stripePlanService.Update(StripePlanUpdateOptions);
                                 };


        Behaves_like<updated_plan_behaviors> behaviors;
    }
}