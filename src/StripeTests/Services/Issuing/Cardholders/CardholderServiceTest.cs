namespace StripeTests.Issuing
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe.Issuing;
    using Xunit;

    public class CardholderServiceTest : BaseStripeTest
    {
        private const string CardholderId = "ich_123";

        private CardholderService service;
        private CardholderCreateOptions createOptions;
        private CardholderUpdateOptions updateOptions;
        private CardholderListOptions listOptions;

        public CardholderServiceTest()
        {
            this.service = new CardholderService();

            this.createOptions = new CardholderCreateOptions()
            {
                Billing = new BillingOptions
                {
                    City = "city",
                    Country = "US",
                    Line1 = "line1",
                    PostalCode = "90210",
                    State = "CA",
                },
                Name = "John Doe",
                Type = "individual",
            };

            this.updateOptions = new CardholderUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new CardholderListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var cardholder = this.service.Create(this.createOptions);
            Assert.NotNull(cardholder);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var cardholder = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(cardholder);
        }

        [Fact]
        public void Get()
        {
            var cardholder = this.service.Get(CardholderId);
            Assert.NotNull(cardholder);
        }

        [Fact]
        public async Task GetAsync()
        {
            var cardholder = await this.service.GetAsync(CardholderId);
            Assert.NotNull(cardholder);
        }

        [Fact]
        public void List()
        {
            var cardholders = this.service.List(this.listOptions);
            Assert.NotNull(cardholders);
        }

        [Fact]
        public async Task ListAsync()
        {
            var cardholders = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(cardholders);
        }

        [Fact]
        public void Update()
        {
            var cardholder = this.service.Update(CardholderId, this.updateOptions);
            Assert.NotNull(cardholder);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var cardholder = await this.service.UpdateAsync(CardholderId, this.updateOptions);
            Assert.NotNull(cardholder);
        }
    }
}
