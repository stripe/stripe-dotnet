//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Stripe.Tests.Xunit;
//using Xunit;

//namespace Stripe.Tests.XUnit
//{
//    public class when_listing_scheduled_query_runs
//    {
//        private readonly StripeList<StripeScheduledQueryRun> _result;

//        public when_listing_scheduled_query_runs()
//        {
//            _result = new StripeScheduledQueryService(Cache.ApiKey).List(new StripeScheduledQueryListOptions { Limit = 3 });
//        }

//        [Fact]
//        public void list_is_iterable()
//        {
//            var count = 0;
//            IEnumerable<StripeScheduledQueryRun> enumerable = _result as IEnumerable<StripeScheduledQueryRun>;
//            foreach (var obj in enumerable)
//            {
//                count += 1;
//            }
//            Assert.Equal(_result.ToList().Count, count);
//        }
//    }
//}
