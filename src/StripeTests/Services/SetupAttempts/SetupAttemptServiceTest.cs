namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class SetupAttemptServiceTest : BaseStripeTest
    {
        private readonly SetupAttemptService service;
        private readonly SetupAttemptListOptions listOptions;

        public SetupAttemptServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new SetupAttemptService(this.StripeClient);

            this.listOptions = new SetupAttemptListOptions
            {
                SetupIntent = "seti_123",
            };
        }

        [Fact]
        public void List()
        {
            var attempts = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/setup_attempts");
            Assert.NotNull(attempts);
            Assert.Equal("list", attempts.Object);
            Assert.Single(attempts.Data);
            Assert.Equal("setup_attempt", attempts.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var attempts = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/setup_attempts");
            Assert.NotNull(attempts);
            Assert.Equal("list", attempts.Object);
            Assert.Single(attempts.Data);
            Assert.Equal("setup_attempt", attempts.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var attempt = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(attempt);
            Assert.Equal("setup_attempt", attempt.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var attempt = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(attempt);
            Assert.Equal("setup_attempt", attempt.Object);
        }
    }
}
