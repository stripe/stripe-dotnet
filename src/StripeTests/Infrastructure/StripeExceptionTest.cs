namespace StripeTests
{
    using System.Linq;
    using System.Net.Http;
    using Newtonsoft.Json.Linq;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class StripeExceptionTest : BaseStripeTest
    {
        public StripeExceptionTest()
        {
        }

        [Fact]
        public void SetsStripeResponse()
        {
            var exception = Assert.Throws<StripeException>(() =>
                new CouponService().Create(new CouponCreateOptions()));

            Assert.NotNull(exception);
            Assert.NotNull(exception.StripeError);
            Assert.NotNull(exception.StripeError.StripeResponse);
        }
    }
}
