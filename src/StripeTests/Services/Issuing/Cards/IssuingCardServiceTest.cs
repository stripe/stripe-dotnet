namespace StripeTests.Issuing
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe.Issuing;
    using Xunit;

    public class IssuingCardServiceTest : BaseStripeTest
    {
        private const string CardId = "ic_123";

        private CardService service;
        private CardCreateOptions createOptions;
        private CardUpdateOptions updateOptions;
        private CardListOptions listOptions;

        public IssuingCardServiceTest()
        {
            this.service = new CardService();

            this.createOptions = new CardCreateOptions()
            {
                Currency = "usd",
                Type = "virtual",
            };

            this.updateOptions = new CardUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new CardListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var card = this.service.Create(this.createOptions);
            Assert.NotNull(card);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var card = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(card);
        }

        [Fact]
        public void Details()
        {
            var cardDetails = this.service.Details(CardId);
            Assert.NotNull(cardDetails);
        }

        [Fact]
        public async Task DetailsAsync()
        {
            var cardDetails = await this.service.DetailsAsync(CardId);
            Assert.NotNull(cardDetails);
        }

        [Fact]
        public void Get()
        {
            var card = this.service.Get(CardId);
            Assert.NotNull(card);
        }

        [Fact]
        public async Task GetAsync()
        {
            var card = await this.service.GetAsync(CardId);
            Assert.NotNull(card);
        }

        [Fact]
        public void List()
        {
            var cards = this.service.List(this.listOptions);
            Assert.NotNull(cards);
        }

        [Fact]
        public async Task ListAsync()
        {
            var cards = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(cards);
        }

        [Fact]
        public void Update()
        {
            var card = this.service.Update(CardId, this.updateOptions);
            Assert.NotNull(card);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var card = await this.service.UpdateAsync(CardId, this.updateOptions);
            Assert.NotNull(card);
        }
    }
}
