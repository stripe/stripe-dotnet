namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class SetupIntentServiceTest : BaseStripeTest
    {
        private const string SetupIntentId = "seti_123";

        private readonly SetupIntentService service;
        private readonly SetupIntentCancelOptions cancelOptions;
        private readonly SetupIntentConfirmOptions confirmOptions;
        private readonly SetupIntentCreateOptions createOptions;
        private readonly SetupIntentListOptions listOptions;
        private readonly SetupIntentUpdateOptions updateOptions;

        public SetupIntentServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new SetupIntentService(this.StripeClient);

            this.cancelOptions = new SetupIntentCancelOptions
            {
            };

            this.confirmOptions = new SetupIntentConfirmOptions
            {
            };

            this.createOptions = new SetupIntentCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },
            };

            this.listOptions = new SetupIntentListOptions
            {
                Limit = 1,
            };

            this.updateOptions = new SetupIntentUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };
        }

        [Fact]
        public void Cancel()
        {
            var intent = this.service.Cancel(SetupIntentId, this.cancelOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/setup_intents/seti_123/cancel");
            Assert.NotNull(intent);
            Assert.Equal("setup_intent", intent.Object);
        }

        [Fact]
        public async Task CancelAsync()
        {
            var intent = await this.service.CancelAsync(SetupIntentId, this.cancelOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/setup_intents/seti_123/cancel");
            Assert.NotNull(intent);
            Assert.Equal("setup_intent", intent.Object);
        }

        [Fact]
        public void Confirm()
        {
            var intent = this.service.Confirm(SetupIntentId, this.confirmOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/setup_intents/seti_123/confirm");
            Assert.NotNull(intent);
            Assert.Equal("setup_intent", intent.Object);
        }

        [Fact]
        public async Task ConfirmAsync()
        {
            var intent = await this.service.ConfirmAsync(SetupIntentId, this.confirmOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/setup_intents/seti_123/confirm");
            Assert.NotNull(intent);
            Assert.Equal("setup_intent", intent.Object);
        }

        [Fact]
        public void Create()
        {
            var intent = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/setup_intents");
            Assert.NotNull(intent);
            Assert.Equal("setup_intent", intent.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var intent = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/setup_intents");
            Assert.NotNull(intent);
            Assert.Equal("setup_intent", intent.Object);
        }

        [Fact]
        public void Get()
        {
            var intent = this.service.Get(SetupIntentId);
            this.AssertRequest(HttpMethod.Get, "/v1/setup_intents/seti_123");
            Assert.NotNull(intent);
            Assert.Equal("setup_intent", intent.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var intent = await this.service.GetAsync(SetupIntentId);
            this.AssertRequest(HttpMethod.Get, "/v1/setup_intents/seti_123");
            Assert.NotNull(intent);
            Assert.Equal("setup_intent", intent.Object);
        }

        [Fact]
        public void GetWithClientSecret()
        {
            var options = new SetupIntentGetOptions
            {
                ClientSecret = "seti_client_secret_123",
            };
            var intent = this.service.Get(SetupIntentId, options);
            this.AssertRequest(HttpMethod.Get, "/v1/setup_intents/seti_123");
            Assert.NotNull(intent);
            Assert.Equal("setup_intent", intent.Object);
        }

        [Fact]
        public void List()
        {
            var intents = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/setup_intents");
            Assert.NotNull(intents);
            Assert.Equal("list", intents.Object);
            Assert.Single(intents.Data);
            Assert.Equal("setup_intent", intents.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var intents = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/setup_intents");
            Assert.NotNull(intents);
            Assert.Equal("list", intents.Object);
            Assert.Single(intents.Data);
            Assert.Equal("setup_intent", intents.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var intent = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(intent);
            Assert.Equal("setup_intent", intent.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var intent = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(intent);
            Assert.Equal("setup_intent", intent.Object);
        }

        [Fact]
        public void Update()
        {
            var intent = this.service.Update(SetupIntentId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/setup_intents/seti_123");
            Assert.NotNull(intent);
            Assert.Equal("setup_intent", intent.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var intent = await this.service.UpdateAsync(SetupIntentId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/setup_intents/seti_123");
            Assert.NotNull(intent);
            Assert.Equal("setup_intent", intent.Object);
        }
    }
}
