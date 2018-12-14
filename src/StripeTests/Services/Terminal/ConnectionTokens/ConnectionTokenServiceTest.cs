namespace StripeTests.Terminal
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe.Terminal;
    using Xunit;

    public class ConnectionTokenServiceTest : BaseStripeTest
    {
        private readonly ConnectionTokenService service;
        private readonly ConnectionTokenCreateOptions createOptions;

        public ConnectionTokenServiceTest()
        {
            this.service = new ConnectionTokenService();

            this.createOptions = new ConnectionTokenCreateOptions
            {
            };
        }

        [Fact]
        public void Create()
        {
            var connectionToken = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/connection_tokens");
            Assert.NotNull(connectionToken);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var connectionToken = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/connection_tokens");
            Assert.NotNull(connectionToken);
        }
    }
}
