namespace StripeTests.Issuing
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe.Issuing;
    using Xunit;

    public class AuthorizationServiceTest : BaseStripeTest
    {
        private const string AuthorizationId = "iauth_123";

        private AuthorizationService service;
        private AuthorizationUpdateOptions updateOptions;
        private AuthorizationListOptions listOptions;

        public AuthorizationServiceTest()
        {
            this.service = new AuthorizationService();

            this.updateOptions = new AuthorizationUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new AuthorizationListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Approve()
        {
            var authorization = this.service.Approve(AuthorizationId);
            Assert.NotNull(authorization);
        }

        [Fact]
        public async Task ApproveAsync()
        {
            var authorization = await this.service.ApproveAsync(AuthorizationId);
            Assert.NotNull(authorization);
        }

        [Fact]
        public void Decline()
        {
            var authorization = this.service.Decline(AuthorizationId);
            Assert.NotNull(authorization);
        }

        [Fact]
        public async Task DeclineAsync()
        {
            var authorization = await this.service.DeclineAsync(AuthorizationId);
            Assert.NotNull(authorization);
        }

        [Fact]
        public void Get()
        {
            var authorization = this.service.Get(AuthorizationId);
            Assert.NotNull(authorization);
        }

        [Fact]
        public async Task GetAsync()
        {
            var authorization = await this.service.GetAsync(AuthorizationId);
            Assert.NotNull(authorization);
        }

        [Fact]
        public void List()
        {
            var authorizations = this.service.List(this.listOptions);
            Assert.NotNull(authorizations);
        }

        [Fact]
        public async Task ListAsync()
        {
            var authorizations = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(authorizations);
        }

        [Fact]
        public void Update()
        {
            var authorization = this.service.Update(AuthorizationId, this.updateOptions);
            Assert.NotNull(authorization);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var authorization = await this.service.UpdateAsync(AuthorizationId, this.updateOptions);
            Assert.NotNull(authorization);
        }
    }
}
