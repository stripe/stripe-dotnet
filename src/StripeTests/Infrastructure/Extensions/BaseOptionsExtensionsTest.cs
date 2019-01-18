namespace StripeTests
{
    using Stripe;
    using Stripe.Infrastructure.Extensions;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class BaseOptionsExtensionsTest : BaseStripeTest
    {
        [Fact]
        public void EncodesExtraParams()
        {
            var options = new TestOptions();
            options.AddExtraParam("extra_param", "some_value");
            options.AddExtraParam("another_extra_param", "some_other_value");

            Assert.Contains(
                "extra_param=some_value&another_extra_param=some_other_value",
                options.ToQueryString());
        }

        [Fact]
        public void EncodesList()
        {
            var options = new TestOptionsWithList();

            Assert.Equal(
                "some_list[0][a_long]=1&some_list[0][a_string]=foo&some_list[1][a_long]=2&some_list[1][a_string]=bar",
                options.ToQueryString());
        }

        [Fact]
        public void EncodesExpandParams()
        {
            var options = new BaseOptions();
            options.AddExpand("example1.subexample1");
            options.AddExpand("example2");
            options.AddExpand("example3.subexample3");

            Assert.Equal(
                "expand[0]=example1.subexample1&expand[1]=example2&expand[2]=example3.subexample3",
                options.ToQueryString());
        }
    }
}
