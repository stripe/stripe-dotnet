namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class SourceServiceTest : BaseStripeTest
    {
        private const string CustomerId = "cus_123";
        private const string SourceId = "src_123";

        private readonly SourceService service;
        private readonly SourceAttachOptions attachOptions;
        private readonly SourceCreateOptions createOptions;
        private readonly SourceListOptions listOptions;
        private readonly SourceUpdateOptions updateOptions;
        private readonly SourceVerifyOptions verifyOptions;

        public SourceServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new SourceService(this.StripeClient);

            this.attachOptions = new SourceAttachOptions
            {
                Source = SourceId,
            };

            this.createOptions = new SourceCreateOptions
            {
                Type = SourceType.AchCreditTransfer,
                Currency = "usd",
                Mandate = new SourceMandateOptions
                {
                    Acceptance = new SourceMandateAcceptanceOptions
                    {
                        Date = DateTime.Parse("Mon, 01 Jan 2001 00:00:00Z"),
                        Ip = "127.0.0.1",
                        NotificationMethod = "manual",
                        Status = "accepted",
                        UserAgent = "User-Agent",
                    },
                },
                Owner = new SourceOwnerOptions
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
                    Email = "email@stripe.com",
                    Name = "Owner Name",
                    Phone = "5555555555",
                },
                Receiver = new SourceReceiverOptions
                {
                    RefundAttributesMethod = "manual",
                },
            };

            this.listOptions = new SourceListOptions
            {
                Limit = 1,
            };

            this.updateOptions = new SourceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.verifyOptions = new SourceVerifyOptions
            {
                Values = new List<string> { "32", "45" },
            };
        }

        [Fact]
        public void Attach()
        {
            var source = this.service.Attach(CustomerId, this.attachOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/sources");
            Assert.NotNull(source);

            // We can't test the object returned as stripe-mock returns an Account
            // Assert.Equal("source", source.Object);
        }

        [Fact]
        public async Task AttachAsync()
        {
            var source = await this.service.AttachAsync(CustomerId, this.attachOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/sources");
            Assert.NotNull(source);

            // We can't test the object returned as stripe-mock returns an Account
            // Assert.Equal("source", source.Object);
        }

        [Fact]
        public void Create()
        {
            var source = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/sources");
            Assert.NotNull(source);
            Assert.Equal("source", source.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var source = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/sources");
            Assert.NotNull(source);
            Assert.Equal("source", source.Object);
        }

        [Fact]
        public void Detach()
        {
            var source = this.service.Detach(CustomerId, SourceId);
            this.AssertRequest(HttpMethod.Delete, "/v1/customers/cus_123/sources/src_123");
            Assert.NotNull(source);

            // We can't test the object returned as stripe-mock returns an Account
            // Assert.Equal("source", source.Object);
        }

        [Fact]
        public async Task DetachAsync()
        {
            var source = await this.service.DetachAsync(CustomerId, SourceId);
            this.AssertRequest(HttpMethod.Delete, "/v1/customers/cus_123/sources/src_123");
            Assert.NotNull(source);

            // We can't test the object returned as stripe-mock returns an Account
            // Assert.Equal("source", source.Object);
        }

        [Fact]
        public void Get()
        {
            var source = this.service.Get(SourceId);
            this.AssertRequest(HttpMethod.Get, "/v1/sources/src_123");
            Assert.NotNull(source);
            Assert.Equal("source", source.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var source = await this.service.GetAsync(SourceId);
            this.AssertRequest(HttpMethod.Get, "/v1/sources/src_123");
            Assert.NotNull(source);
            Assert.Equal("source", source.Object);
        }

        [Fact]
        public void GetWithClientSecret()
        {
            var options = new SourceGetOptions
            {
                ClientSecret = "src_client_secret_123",
            };
            var source = this.service.Get(SourceId, options);
            this.AssertRequest(HttpMethod.Get, "/v1/sources/src_123");
            Assert.NotNull(source);
            Assert.Equal("source", source.Object);
        }

        [Fact]
        public void List()
        {
            var sources = this.service.List(CustomerId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/sources");
            Assert.NotNull(sources);
            Assert.Equal("list", sources.Object);
            Assert.Single(sources.Data);

            // We can't test the object returned as stripe-mock returns an Account
            // Assert.Equal("source", sources.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var sources = await this.service.ListAsync(CustomerId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/sources");
            Assert.NotNull(sources);
            Assert.Equal("list", sources.Object);
            Assert.Single(sources.Data);

            // We can't test the object returned as stripe-mock returns an Account
            // Assert.Equal("source", sources.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var source = this.service.ListAutoPaging(CustomerId, this.listOptions).First();
            Assert.NotNull(source);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var source = await this.service.ListAutoPagingAsync(CustomerId, this.listOptions).FirstAsync();
            Assert.NotNull(source);
        }

        [Fact]
        public void Update()
        {
            var source = this.service.Update(SourceId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/sources/src_123");
            Assert.NotNull(source);
            Assert.Equal("source", source.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var source = await this.service.UpdateAsync(SourceId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/sources/src_123");
            Assert.NotNull(source);
            Assert.Equal("source", source.Object);
        }

        [Fact]
        public void Verify()
        {
            var source = this.service.Verify(SourceId, this.verifyOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/sources/src_123/verify");
            Assert.NotNull(source);
            Assert.Equal("source", source.Object);
        }

        [Fact]
        public async Task VerifyAsync()
        {
            var source = await this.service.VerifyAsync(SourceId, this.verifyOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/sources/src_123/verify");
            Assert.NotNull(source);
            Assert.Equal("source", source.Object);
        }
    }
}
