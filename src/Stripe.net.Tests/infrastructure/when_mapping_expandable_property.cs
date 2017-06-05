using Machine.Specifications;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe.Tests
{
    public class when_mapping_expandable_property
    {
        public class TestEntityWithId : StripeEntityWithId
        {
            public string Name { get; set; }
        }

        public class TestParent
        {
            public string FooId { get; set; }

            [JsonIgnore]
            public TestEntityWithId Foo { get; set; }

            [JsonProperty("foo")]
            internal object FooInternal
            {
                set
                {
                    StringOrObject<TestEntityWithId>.Map(value, s => FooId = s, o => Foo = o);
                }
            }
        }

        const string SourceDataNonExpanded = "{ foo: 'abcde' }";
        const string SourceDataExpanded = "{ foo: { Id: 'abcde', Name: 'Bob' } }";
        private static TestParent _resultNonExpanded;
        private static TestParent _resultExpanded;

        Because of = () =>
        {
            _resultNonExpanded = Mapper<TestParent>.MapFromJson(SourceDataNonExpanded);
            _resultExpanded = Mapper<TestParent>.MapFromJson(SourceDataExpanded);
        };

        It should_have_id_on_non_expanded_item = () =>
            _resultNonExpanded.FooId.ShouldNotBeEmpty();

        It should_have_id_on_expanded_item = () =>
            _resultExpanded.FooId.ShouldNotBeEmpty();

        It should_not_have_object_on_non_expanded_item = () =>
            _resultNonExpanded.Foo.ShouldBeNull();

        It should_have_object_on_expanded_item = () =>
            _resultExpanded.Foo.ShouldNotBeNull();

        It should_have_id_in_expanded_object = () =>
            _resultExpanded.Foo.Id.ShouldNotBeEmpty();
    }
}
