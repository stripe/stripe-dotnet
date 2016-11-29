using Machine.Specifications;
using Stripe.Infrastructure;
using Stripe.Tests.test_data;

namespace Stripe.Tests
{
    class when_serializing_an_equals_datefilter
    {
        private const string origurl = "http://test/foo";
        private static sample_object _testObject;
        private static string _result;

        Establish context = () =>
            _testObject = new sample_object();

        Because of = () =>
            _result = new test_service().ApplyAllParameters(_testObject, origurl, false);

        It should_contain_plain_equals = () =>
            _result.ShouldContain("dateequals=946684800");

        It should_not_contain_complex_filter = () =>
            _result.ShouldNotContain("dateequals[");
    }
}