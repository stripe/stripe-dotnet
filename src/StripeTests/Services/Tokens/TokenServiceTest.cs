namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class TokenServiceTest : BaseStripeTest
    {
        private const string TokenId = "tok_123";

        private readonly TokenService service;
        private readonly TokenCreateOptions createOptions;

        public TokenServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new TokenService();

            this.createOptions = new TokenCreateOptions
            {
                Card = new CreditCardOptions
                {
                    AddressCity = "City",
                    AddressCountry = "US",
                    AddressLine1 = "Line 1",
                    AddressLine2 = "Line 2",
                    AddressState = "CA",
                    AddressZip = "90210",
                    Cvc = "123",
                    ExpMonth = 10,
                    ExpYear = DateTime.Now.Year + 1,
                    Name = "Name",
                    Number = "4242424242424242",
                },
            };
        }

        [Fact]
        public void Create()
        {
            var token = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
            Assert.NotNull(token);
            Assert.Equal("token", token.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var token = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
            Assert.NotNull(token);
            Assert.Equal("token", token.Object);
        }

        [Fact]
        public void Get()
        {
            var token = this.service.Get(TokenId);
            this.AssertRequest(HttpMethod.Get, "/v1/tokens/tok_123");
            Assert.NotNull(token);
            Assert.Equal("token", token.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var token = await this.service.GetAsync(TokenId);
            this.AssertRequest(HttpMethod.Get, "/v1/tokens/tok_123");
            Assert.NotNull(token);
            Assert.Equal("token", token.Object);
        }
    }
}
