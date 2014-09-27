using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_plans
    {
        private static List<StripePlan> _stripePlanList;
        private static StripePlanService _stripePlanService;

        Establish context = () =>
        {
            _stripePlanService = new StripePlanService();

            _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());
            _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());
            _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());
            _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());
        };

        Because of = () =>
            _stripePlanList = _stripePlanService.List().ToList();

        It should_have_atleast_4_entries = () =>
            _stripePlanList.Count.ShouldBeGreaterThanOrEqualTo(4);
    }
}