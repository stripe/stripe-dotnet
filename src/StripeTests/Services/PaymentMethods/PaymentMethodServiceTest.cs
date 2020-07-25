namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class PaymentMethodServiceTest : BaseStripeTest
    {
        private const string PaymentMethodId = "pm_123";

        private readonly PaymentMethodService service;
        private readonly PaymentMethodAttachOptions attachOptions;
        private readonly PaymentMethodCreateOptions createOptions;
        private readonly PaymentMethodDetachOptions detachOptions;
        private readonly PaymentMethodListOptions listOptions;
        private readonly PaymentMethodUpdateOptions updateOptions;

        public PaymentMethodServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new PaymentMethodService(this.StripeClient);

            this.attachOptions = new PaymentMethodAttachOptions
            {
                Customer = "cus_123",
            };

            this.createOptions = new PaymentMethodCreateOptions
            {
                Card = new PaymentMethodCardOptions
                {
                    Token = "tok_123",
                },
                Type = "card",
            };

            this.detachOptions = new PaymentMethodDetachOptions
            {
            };

            this.listOptions = new PaymentMethodListOptions
            {
                Customer = "cus_123",
                Type = "card",
            };

            this.updateOptions = new PaymentMethodUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };
        }

        [Fact]
        public void Attach()
        {
            var payment_method = this.service.Attach(PaymentMethodId, this.attachOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_methods/pm_123/attach");
            Assert.NotNull(payment_method);
            Assert.Equal("payment_method", payment_method.Object);
        }

        [Fact]
        public async Task AttachAsync()
        {
            var payment_method = await this.service.AttachAsync(PaymentMethodId, this.attachOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_methods/pm_123/attach");
            Assert.NotNull(payment_method);
            Assert.Equal("payment_method", payment_method.Object);
        }

        [Fact]
        public void Create()
        {
            var payment_method = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_methods");
            Assert.NotNull(payment_method);
            Assert.Equal("payment_method", payment_method.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var payment_method = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_methods");
            Assert.NotNull(payment_method);
            Assert.Equal("payment_method", payment_method.Object);
        }

        [Fact]
        public void Detach()
        {
            var payment_method = this.service.Detach(PaymentMethodId, this.detachOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_methods/pm_123/detach");
            Assert.NotNull(payment_method);
            Assert.Equal("payment_method", payment_method.Object);
        }

        [Fact]
        public async Task DetachAsync()
        {
            var payment_method = await this.service.DetachAsync(PaymentMethodId, this.detachOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_methods/pm_123/detach");
            Assert.NotNull(payment_method);
            Assert.Equal("payment_method", payment_method.Object);
        }

        [Fact]
        public void Get()
        {
            var payment_method = this.service.Get(PaymentMethodId);
            this.AssertRequest(HttpMethod.Get, "/v1/payment_methods/pm_123");
            Assert.NotNull(payment_method);
            Assert.Equal("payment_method", payment_method.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var payment_method = await this.service.GetAsync(PaymentMethodId);
            this.AssertRequest(HttpMethod.Get, "/v1/payment_methods/pm_123");
            Assert.NotNull(payment_method);
            Assert.Equal("payment_method", payment_method.Object);
        }

        [Fact]
        public void List()
        {
            var payment_methods = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/payment_methods");
            Assert.NotNull(payment_methods);
            Assert.Equal("list", payment_methods.Object);
            Assert.Single(payment_methods.Data);
            Assert.Equal("payment_method", payment_methods.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var payment_methods = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/payment_methods");
            Assert.NotNull(payment_methods);
            Assert.Equal("list", payment_methods.Object);
            Assert.Single(payment_methods.Data);
            Assert.Equal("payment_method", payment_methods.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var payment_method = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(payment_method);
            Assert.Equal("payment_method", payment_method.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var payment_method = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(payment_method);
            Assert.Equal("payment_method", payment_method.Object);
        }
    }
}
