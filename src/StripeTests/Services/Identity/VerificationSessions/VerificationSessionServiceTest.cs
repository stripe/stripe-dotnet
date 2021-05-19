namespace StripeTests.Identity
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe.Identity;
    using Xunit;

    public class VerificationSessionServiceTest : BaseStripeTest
    {
        private const string VerificationSessionId = "vs_123";

        private readonly VerificationSessionService service;
        private readonly VerificationSessionCreateOptions createOptions;
        private readonly VerificationSessionUpdateOptions updateOptions;
        private readonly VerificationSessionListOptions listOptions;

        public VerificationSessionServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new VerificationSessionService(this.StripeClient);

            this.createOptions = new VerificationSessionCreateOptions
            {
                Type = "id_number",
            };

            this.updateOptions = new VerificationSessionUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new VerificationSessionListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Cancel()
        {
            var verificationSession = this.service.Cancel(VerificationSessionId);
            this.AssertRequest(HttpMethod.Post, "/v1/identity/verification_sessions/vs_123/cancel");
            Assert.NotNull(verificationSession);
        }

        [Fact]
        public async Task CancelAsync()
        {
            var verificationSession = await this.service.CancelAsync(VerificationSessionId);
            this.AssertRequest(HttpMethod.Post, "/v1/identity/verification_sessions/vs_123/cancel");
            Assert.NotNull(verificationSession);
        }

        [Fact]
        public void Redact()
        {
            var verificationSession = this.service.Redact(VerificationSessionId);
            this.AssertRequest(HttpMethod.Post, "/v1/identity/verification_sessions/vs_123/redact");
            Assert.NotNull(verificationSession);
        }

        [Fact]
        public async Task RedactAsync()
        {
            var verificationSession = await this.service.RedactAsync(VerificationSessionId);
            this.AssertRequest(HttpMethod.Post, "/v1/identity/verification_sessions/vs_123/redact");
            Assert.NotNull(verificationSession);
        }

        [Fact]
        public void Get()
        {
            var verificationSession = this.service.Get(VerificationSessionId);
            this.AssertRequest(HttpMethod.Get, "/v1/identity/verification_sessions/vs_123");
            Assert.NotNull(verificationSession);
        }

        [Fact]
        public async Task GetAsync()
        {
            var verificationSession = await this.service.GetAsync(VerificationSessionId);
            this.AssertRequest(HttpMethod.Get, "/v1/identity/verification_sessions/vs_123");
            Assert.NotNull(verificationSession);
        }

        [Fact]
        public void Create()
        {
            var verificationSession = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/identity/verification_sessions");
            Assert.NotNull(verificationSession);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var verificationSession = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/identity/verification_sessions");
            Assert.NotNull(verificationSession);
        }

        [Fact]
        public void List()
        {
            var verificationSession = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/identity/verification_sessions");
            Assert.NotNull(verificationSession);
        }

        [Fact]
        public async Task ListAsync()
        {
            var verificationSession = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/identity/verification_sessions");
            Assert.NotNull(verificationSession);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var verificationSession = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(verificationSession);
            Assert.Equal("identity.verification_session", verificationSession.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var verificationSession = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(verificationSession);
            Assert.Equal("identity.verification_session", verificationSession.Object);
        }

        [Fact]
        public void Update()
        {
            var verificationSession = this.service.Update(VerificationSessionId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/identity/verification_sessions/vs_123");
            Assert.NotNull(verificationSession);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var verificationSession = await this.service.UpdateAsync(VerificationSessionId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/identity/verification_sessions/vs_123");
            Assert.NotNull(verificationSession);
        }
    }
}
