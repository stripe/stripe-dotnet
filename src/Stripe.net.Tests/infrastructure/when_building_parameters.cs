using Machine.Specifications;
using Stripe.Infrastructure;
using Stripe.Tests.test_data;

namespace Stripe.Tests
{
    public class when_building_parameters
    {
        private const string origurl = "http://test/foo";
        private static sample_object _testObject;
        private static string _result;

        Establish context = () =>
            _testObject = new sample_object();

        Because of = () =>
            _result = new test_service().ApplyAllParameters(_testObject, origurl, false);

        It should_start_with_original_url = () =>
            _result.ShouldStartWith(origurl);

        It should_contain_querystring_separator = () =>
            _result.ShouldStartWith(origurl + "?");

        It should_not_contain_property_without_attribute = () =>
            _result.ShouldNotContain("StringWithoutAttribute=");

        It should_use_name_from_property_attribute = () =>
            _result.ShouldContain("differentname=");

        It should_not_contain_null_string_property = () =>
            _result.ShouldNotContain("stringcontainingnull=");

        It should_contain_string_with_value = () =>
            _result.ShouldContain("stringcontainingtext=Foo");

        It should_contain_int_property = () =>
            _result.ShouldContain("number=42");

        It should_not_contain_null_int_property = () =>
            _result.ShouldNotContain("nullnumber=");

        It should_contain_metadata_as_inline_items = () =>
            _result.ShouldContain("metadata[A]=Value-A");
    }
}