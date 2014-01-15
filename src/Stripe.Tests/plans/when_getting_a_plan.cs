using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_getting_a_plan
	{
		protected static StripePlanCreateOptions StripePlanCreateOptions;
		protected static StripePlan StripePlan;

		private static StripePlanService _stripePlanService;
		private static string _createdStripePlanId;

		Establish context = () =>
		{
			_stripePlanService = new StripePlanService();
			StripePlanCreateOptions = test_data.stripe_plan_create_options.Valid();

            StripePlan stripePlan = _stripePlanService.Create(StripePlanCreateOptions).Await();
			_createdStripePlanId = stripePlan.Id;
		};

		Because of = () =>
            StripePlan = _stripePlanService.Get(_createdStripePlanId).Await();

		Behaves_like<plan_behaviors> behaviors;
	}
}