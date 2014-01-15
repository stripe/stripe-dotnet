using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_deleting_a_plan
	{
		private static StripePlanCreateOptions _stripePlanCreateOptions;
		private static StripePlanService _stripePlanService;
		private static string _createdStripePlanId;

		Establish context = () =>
		{
			_stripePlanService = new StripePlanService();
			_stripePlanCreateOptions = test_data.stripe_plan_create_options.Valid();

            StripePlan stripePlan = _stripePlanService.Create(_stripePlanCreateOptions).Await();
			_createdStripePlanId = stripePlan.Id;
		};

		Because of = () =>
            _stripePlanService.Delete(_createdStripePlanId).Await();

		It should_throw_exception_when_getting = () =>
		{
            var exception = Catch.Exception(() => _stripePlanService.Get(_createdStripePlanId).Await());
			exception.Message.ShouldContain("No such plan");
		};
	}
}