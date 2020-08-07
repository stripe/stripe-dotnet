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
        private readonly TokenCreateOptions createPersonOptions;

        public TokenServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new TokenService(this.StripeClient);

            this.createOptions = new TokenCreateOptions
            {
                Card = new TokenCardOptions
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

            this.createPersonOptions = new TokenCreateOptions
            {
                Person = new TokenPersonOptions
                {
                    Address = new AddressOptions
                    {
                        State = "CA",
                        City = "City",
                        Line1 = "Line1",
                        Line2 = "Line2",
                        PostalCode = "90210",
                        Country = "US",
                    },
                    FirstName = "John",
                    Relationship = new TokenPersonRelationshipOptions
                    {
                        Owner = true,
                        PercentOwnership = 30.5m,
                        Representative = true,
                    },
                    Verification = new TokenPersonVerificationOptions
                    {
                        AdditionalDocument = new TokenPersonVerificationAdditionalDocumentOptions
                        {
                            Back = "file_abc",
                            Front = "file_def",
                        },
                        Document = new TokenPersonVerificationDocumentOptions
                        {
                            Back = "file_123",
                            Front = "file_345",
                        },
                    },
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
        public void CreateTokenPerson()
        {
            var tokenPerson = this.service.Create(this.createPersonOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
            Assert.NotNull(tokenPerson);
            Assert.Equal("token", tokenPerson.Object);
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
