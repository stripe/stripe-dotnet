using Machine.Specifications;
using Stripe.Infrastructure;
using Stripe.Tests.test_data;

namespace Stripe.Tests
{
    public class when_serializing_a_datefilter_query
    {
        private const string origurl = "http://test/foo";
        private static sample_object _testObject;
        private static string _result;

        // 1/1/2000 at 00:05:00 GMT
        private static string UtcDateOne => "946702800";

        // 1/1/2001 at 00:00:00 GMT
        private static string UtcDateTwo => "978307200";

        Establish context = () =>
            _testObject = new sample_object();

        Because of = () =>
            _result = new test_service().ApplyAllParameters(_testObject, origurl, false);

        It should_contain_less_than = () =>
            _result.ShouldContain($"datelessthan[lt]={UtcDateOne}");

        It should_contain_first_part_of_complex_query = () =>
            _result.ShouldContain($"datecomplex[gt]={UtcDateOne}");

        It should_contain_second_part_of_complex_query = () =>
            _result.ShouldContain($"datecomplex[lt]={UtcDateTwo}");
    }
}