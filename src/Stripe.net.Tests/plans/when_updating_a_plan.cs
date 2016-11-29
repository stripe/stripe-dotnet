using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_updating_a_plan
    {
        protected static StripePlanCreateOptions StripePlanCreateOptions;
        protected static StripePlanUpdateOptions StripePlanUpdateOptions;
        protected static StripePlan StripePlan;

        private static StripePlanService _stripePlanService;
        private static string _createdStripePlanId;

        Establish context = () =>
        {
            _stripePlanService = new StripePlanService();
            StripePlanCreateOptions = test_data.stripe_plan_create_options.Valid();

            var stripePlan = _stripePlanService.Create(StripePlanCreateOptions);
            _createdStripePlanId = stripePlan.Id;

            StripePlanUpdateOptions = test_data.stripe_plan_update_options.Valid();
        };

        Because of = () =>
            StripePlan = _stripePlanService.Update(_createdStripePlanId, StripePlanUpdateOptions);

        It should_have_the_new_name = () =>
            StripePlan.Name.ShouldEqual(StripePlanUpdateOptions.Name);

        It should_have_metadata = () =>
            StripePlan.Metadata.Count.ShouldBeGreaterThan(0);

        It should_have_correct_metadata = () =>
            StripePlan.Metadata.ShouldContainOnly(StripePlanUpdateOptions.Metadata);

        It should_have_the_new_statement_descriptor = () =>
            StripePlan.StatementDescriptor.ShouldEqual(StripePlanUpdateOptions.StatementDescriptor);
    }
}