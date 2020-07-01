namespace StripeTests.Issuing
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe.Issuing;
    using Xunit;

    public class IssuingCardServiceTest : BaseStripeTest
    {
        private const string CardId = "ic_123";

        private readonly CardService service;
        private readonly CardCreateOptions createOptions;
        private readonly CardUpdateOptions updateOptions;
        private readonly CardListOptions listOptions;

        public IssuingCardServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new CardService(this.StripeClient);

            this.createOptions = new CardCreateOptions
            {
                Cardholder = "ich_123",
                Currency = "usd",
                SpendingControls = new CardSpendingControlsOptions
                {
                    SpendingLimits = new List<CardSpendingControlsSpendingLimitOptions>
                    {
                        new CardSpendingControlsSpendingLimitOptions
                        {
                            Amount = 1000,
                            Categories = new List<string>
                            {
                                "financial_institutions",
                            },
                            Interval = "all_time",
                        },
                    },
                },
                Type = "virtual",
            };

            this.updateOptions = new CardUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new CardListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var card = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/cards");
            Assert.NotNull(card);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var card = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/cards");
            Assert.NotNull(card);
        }

        [Fact]
        public void Get()
        {
            var card = this.service.Get(CardId);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cards/ic_123");
            Assert.NotNull(card);
        }

        [Fact]
        public async Task GetAsync()
        {
            var card = await this.service.GetAsync(CardId);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cards/ic_123");
            Assert.NotNull(card);
        }

        [Fact]
        public void List()
        {
            var cards = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cards");
            Assert.NotNull(cards);
        }

        [Fact]
        public async Task ListAsync()
        {
            var cards = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cards");
            Assert.NotNull(cards);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var card = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(card);
            Assert.Equal("issuing.card", card.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var card = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(card);
            Assert.Equal("issuing.card", card.Object);
        }

        [Fact]
        public void Update()
        {
            var card = this.service.Update(CardId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/cards/ic_123");
            Assert.NotNull(card);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var card = await this.service.UpdateAsync(CardId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/cards/ic_123");
            Assert.NotNull(card);
        }
    }
}
