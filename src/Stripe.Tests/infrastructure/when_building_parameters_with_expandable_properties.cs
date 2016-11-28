using Machine.Specifications;
using Stripe.Infrastructure;

namespace Stripe.Tests
{
    public class when_building_parameters_with_expandable_properties
    {
        public class TestService : StripeService
        {
            public TestService() : base(null) { }
            public bool ExpandSimple { get; set; }
            public bool ExpandMultiWordProperty { get; set; }
        }

        private static TestService _testService;
        private const string origurl = "http://test/foo";
        private static string _result;
        private static string _listResult;

        Establish context = () =>
        {
            _testService = new TestService();
            _testService.ExpandSimple = true;
            _testService.ExpandMultiWordProperty = true;
        };

        Because of = () =>
        {
            _result = _testService.ApplyAllParameters(null, origurl, false);
            _listResult = _testService.ApplyAllParameters(null, origurl, true);
        };

        It should_contain_expanded_simple_property = () =>
            _result.ShouldContain("expand[]=simple");

        It should_contain_expanded_multi_word_property = () =>
            _result.ShouldContain("expand[]=multi_word_property");

        It should_contain_expanded_data_simple_property = () =>
            _listResult.ShouldContain("expand[]=data.simple");

        It should_contain_expanded_data_multi_word_property = () =>
            _listResult.ShouldContain("expand[]=data.multi_word_property");
    }
}
