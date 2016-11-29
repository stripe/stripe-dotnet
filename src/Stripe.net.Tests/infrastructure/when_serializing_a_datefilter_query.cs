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

        Establish context = () =>
            _testObject = new sample_object();

        Because of = () =>
            _result = new test_service().ApplyAllParameters(_testObject, origurl, false);

        It should_not_contain_plain_equals = () =>
            _result.ShouldNotContain("datelessthan=");

        It should_contain_less_than = () =>
            _result.ShouldContain("datelessthan[lt]=946684800");

        It should_contain_first_part_of_complex_query = () =>
            _result.ShouldContain("datecomplex[gt]=946684800");

        It should_contain_second_part_of_complex_query = () =>
            _result.ShouldContain("datecomplex[lt]=4102444800");
    }
}