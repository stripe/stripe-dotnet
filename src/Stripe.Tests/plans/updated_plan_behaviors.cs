using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class updated_plan_behaviors
    {
        protected static StripePlanUpdateOptions StripePlanUpdateOptions;
        protected static StripePlan StripePlan;

        It should_have_the_correct_id = () =>
            StripePlan.Id.ShouldEqual(StripePlanUpdateOptions.Id);

        It should_have_the_correct_name = () =>
            StripePlan.Name.ShouldEqual(StripePlanUpdateOptions.Name);

        It should_have_the_correct_live_mode = () =>
            StripePlan.LiveMode.ShouldEqual(false);
    }
}
