namespace StripeTests
{
    using System.Threading.Tasks;
    using Stripe;
    using Xunit;

    public class StripeExceptionTest : BaseStripeTest
    {
        [Fact]
        public async Task SetsStripeResponse()
        {
            var exception = await Assert.ThrowsAsync<StripeException>(async () =>
                await new CouponService().CreateAsync(new CouponCreateOptions()));

            Assert.NotNull(exception);
            Assert.NotNull(exception.StripeError);
            Assert.NotNull(exception.StripeError.StripeResponse);
        }
    }
}
