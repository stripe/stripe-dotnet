using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace Stripe.net.Tests
{
    public class when_listing_scheduled_query_runs
    {
        private static StripeList<StripeScheduledQueryRun> _stripeQueryRuns;
        private static StripeScheduledQueryService _stripeScheduledQueryService;

        Establish context = () =>
        {
            _stripeScheduledQueryService = new StripeScheduledQueryService();
            _stripeQueryRuns = _stripeScheduledQueryService.List();
        };
    }
}
