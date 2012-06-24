using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace Stripe.Tests.plans
{
    public class when_used_with_api_key
    {
        protected static StripePlanCreateOptions StripePlanCreateOptions;
        protected static StripePlan StripePlan;

        private static StripePlanService _stripePlanService;

        Establish context = () =>
        {
            _stripePlanService = new StripePlanService("[your api key here]");
            StripePlanCreateOptions = test_data.stripe_plan_create_options.Valid();
        };

        Because of = () =>
            StripePlan = _stripePlanService.Create(StripePlanCreateOptions);

        Behaves_like<plan_behaviors> behaviors;
    }
}
