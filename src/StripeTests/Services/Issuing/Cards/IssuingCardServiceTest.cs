namespace StripeTests.Issuing
{
    using System.Collections.Generic;
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

        public IssuingCardServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new CardService();

            this.createOptions = new CardCreateOptions
            {
                AuthorizationControls = new AuthorizationControlsOptions
                {
                    MaxAmount = 123,
                },
                Currency = "usd",
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
        public void Details()
        {
            var cardDetails = this.service.Details(CardId);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cards/ic_123/details");
            Assert.NotNull(cardDetails);
        }

        [Fact]
        public async Task DetailsAsync()
        {
            var cardDetails = await this.service.DetailsAsync(CardId);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cards/ic_123/details");
            Assert.NotNull(cardDetails);
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
