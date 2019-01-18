namespace StripeTests
{
    using Stripe.Infrastructure;
    using Xunit;

    public class StringUtilsTest : BaseStripeTest
    {
        [Fact]
        public void ToSnakeCase()
        {
            var testCases = new[]
            {
                new { data = "Foo", want = "foo" },
                new { data = "FooBar", want = "foo_bar" },
                new { data = "FooBar123", want = "foo_bar123" },
                new { data = "Foo123Bar", want = "foo123_bar" },
                new { data = "FOOBar", want = "foo_bar" },
                new { data = "FooBAR", want = "foo_bar" },
                new { data = "FOOBAR", want = "foobar" },
                new { data = "FOO_BAR", want = "foo_bar" },
            };

            foreach (var testCase in testCases)
            {
                Assert.Equal(testCase.want, StringUtils.ToSnakeCase(testCase.data));
            }
        }
    }
}
