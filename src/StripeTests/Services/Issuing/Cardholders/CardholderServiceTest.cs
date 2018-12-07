namespace StripeTests.Issuing
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Stripe.Issuing;
    using Xunit;

    public class CardholderServiceTest : BaseStripeTest
    {
        private const string CardholderId = "ich_123";

        private readonly CardholderService service;
        private readonly CardholderCreateOptions createOptions;
        private readonly CardholderUpdateOptions updateOptions;
        private readonly CardholderListOptions listOptions;

        public CardholderServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new CardholderService();

            this.createOptions = new CardholderCreateOptions
            {
                Billing = new BillingOptions
                {
                    Address = new AddressOptions
                    {
                        City = "city",
                        Country = "US",
                        Line1 = "line1",
                        PostalCode = "90210",
                        State = "CA",
                    },
                    Name = "Billing Name",
                },
                Name = "John Doe",
                Type = "individual",
            };

            this.updateOptions = new CardholderUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new CardholderListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var cardholder = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/cardholders");
            Assert.NotNull(cardholder);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var cardholder = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/cardholders");
            Assert.NotNull(cardholder);
        }

        [Fact]
        public void Get()
        {
            var cardholder = this.service.Get(CardholderId);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cardholders/ich_123");
            Assert.NotNull(cardholder);
        }

        [Fact]
        public async Task GetAsync()
        {
            var cardholder = await this.service.GetAsync(CardholderId);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cardholders/ich_123");
            Assert.NotNull(cardholder);
        }

        [Fact]
        public void List()
        {
            var cardholders = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cardholders");
            Assert.NotNull(cardholders);
        }

        [Fact]
        public async Task ListAsync()
        {
            var cardholders = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cardholders");
            Assert.NotNull(cardholders);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var cardholders = this.service.ListAutoPaging(this.listOptions).ToList();
            Assert.NotNull(cardholders);
        }

        [Fact]
        public void Update()
        {
            var cardholder = this.service.Update(CardholderId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/cardholders/ich_123");
            Assert.NotNull(cardholder);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var cardholder = await this.service.UpdateAsync(CardholderId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/cardholders/ich_123");
            Assert.NotNull(cardholder);
        }
    }
}
