namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    /*
     * We do not test the object property on returned values for most methods
     * as stripe-mock returns a Bank Account for those.
     */
    public class StripeCardServiceTest : BaseStripeTest
    {
        private const string CardId = "card_123";
        private const string CustomerId = "cus_123";

        private StripeCardService service;
        private StripeCardCreateOptions createOptions;
        private StripeCardUpdateOptions updateOptions;
        private StripeCardListOptions listOptions;

        public StripeCardServiceTest()
        {
            this.service = new StripeCardService();

            this.createOptions = new StripeCardCreateOptions()
            {
                SourceToken = "tok_123",
            };

            this.updateOptions = new StripeCardUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new StripeCardListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var card = this.service.Create(CustomerId, this.createOptions);
            Assert.NotNull(card);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var card = await this.service.CreateAsync(CustomerId, this.createOptions);
            Assert.NotNull(card);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(CustomerId, CardId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(CustomerId, CardId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var card = this.service.Get(CustomerId, CardId);
            Assert.NotNull(card);
        }

        [Fact]
        public async Task GetAsync()
        {
            var card = await this.service.GetAsync(CustomerId, CardId);
            Assert.NotNull(card);
        }

        [Fact]
        public void List()
        {
            var cards = this.service.List(CustomerId, this.listOptions);
            Assert.NotNull(cards);
            Assert.Equal("list", cards.Object);
            Assert.Single(cards.Data);
        }

        [Fact]
        public async Task ListAsync()
        {
            var cards = await this.service.ListAsync(CustomerId, this.listOptions);
            Assert.NotNull(cards);
            Assert.Equal("list", cards.Object);
            Assert.Single(cards.Data);
        }

        [Fact]
        public void Update()
        {
            var card = this.service.Update(CustomerId, CardId, this.updateOptions);
            Assert.NotNull(card);
            Assert.Equal("card", card.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var card = await this.service.UpdateAsync(CustomerId, CardId, this.updateOptions);
            Assert.NotNull(card);
            Assert.Equal("card", card.Object);
        }
    }
}
