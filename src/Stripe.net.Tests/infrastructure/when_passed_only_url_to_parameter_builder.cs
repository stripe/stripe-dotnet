using Machine.Specifications;
using Stripe.Infrastructure;
using Stripe.Tests.test_data;

namespace Stripe.Tests
{
    public class when_passed_only_url_to_parameter_builder
    {
        private const string original = "http://foo";
        private static string _result;

        Because of = () =>
            _result = new test_service().ApplyAllParameters(null, original, false);

        It should_return_original = () =>
            _result.ShouldEqual(original);
    }
}