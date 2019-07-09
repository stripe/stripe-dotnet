namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class PaymentSourceServiceTest : BaseStripeTest
    {
        private const string CustomerId = "cus_123";
        private const string PaymentSourceId = "card_123";

        private readonly PaymentSourceService service;
        private readonly PaymentSourceCreateOptions createOptions;
        private readonly PaymentSourceUpdateOptions updateOptions;
        private readonly PaymentSourceListOptions listOptions;

        public PaymentSourceServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new PaymentSourceService(this.StripeClient);

            this.createOptions = new PaymentSourceCreateOptions
            {
                Source = "tok_123",
            };

            this.updateOptions = new PaymentSourceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new PaymentSourceListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var paymentSource = this.service.Create(CustomerId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/sources");
            Assert.NotNull(paymentSource);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var paymentSource = await this.service.CreateAsync(CustomerId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/sources");
            Assert.NotNull(paymentSource);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(CustomerId, PaymentSourceId);
            this.AssertRequest(HttpMethod.Delete, "/v1/customers/cus_123/sources/card_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(CustomerId, PaymentSourceId);
            this.AssertRequest(HttpMethod.Delete, "/v1/customers/cus_123/sources/card_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var paymentSource = this.service.Get(CustomerId, PaymentSourceId);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/sources/card_123");
            Assert.NotNull(paymentSource);
        }

        [Fact]
        public async Task GetAsync()
        {
            var paymentSource = await this.service.GetAsync(CustomerId, PaymentSourceId);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/sources/card_123");
            Assert.NotNull(paymentSource);
        }

        [Fact]
        public void List()
        {
            var paymentSources = this.service.List(CustomerId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/sources");
            Assert.NotNull(paymentSources);
            Assert.Equal("list", paymentSources.Object);
            Assert.Single(paymentSources.Data);
        }

        [Fact]
        public async Task ListAsync()
        {
            var paymentSources = await this.service.ListAsync(CustomerId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/sources");
            Assert.NotNull(paymentSources);
            Assert.Equal("list", paymentSources.Object);
            Assert.Single(paymentSources.Data);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var paymentSources = this.service.ListAutoPaging(CustomerId, this.listOptions).ToList();
            Assert.NotNull(paymentSources);
        }

        [Fact]
        public void Update()
        {
            var paymentSource = this.service.Update(CustomerId, PaymentSourceId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/sources/card_123");
            Assert.NotNull(paymentSource);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var paymentSource = await this.service.UpdateAsync(CustomerId, PaymentSourceId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/sources/card_123");
            Assert.NotNull(paymentSource);
        }
    }
}
