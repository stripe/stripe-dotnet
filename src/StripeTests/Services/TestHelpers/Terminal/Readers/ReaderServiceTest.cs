namespace StripeTests.TestHelpers.Terminal
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Stripe.TestHelpers.Terminal;
    using Xunit;

    public class ReaderServiceTest : BaseStripeTest
    {
        private const string ReaderId = "ds_123";

        private readonly ReaderService service;

        public ReaderServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new ReaderService(this.StripeClient);
        }

        [Fact]
        public async Task PresentPaymentMethodAsync()
        {
            var reader = await this.service.PresentPaymentMethodAsync(ReaderId);
            this.AssertRequest(HttpMethod.Post, "/v1/test_helpers/terminal/readers/ds_123/present_payment_method");
            Assert.NotNull(reader);
        }
    }
}
