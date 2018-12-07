namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class OrderServiceTest : BaseStripeTest
    {
        private const string OrderId = "or_123";

        private readonly OrderService service;
        private readonly OrderCreateOptions createOptions;
        private readonly OrderUpdateOptions updateOptions;
        private readonly OrderPayOptions payOptions;
        private readonly OrderListOptions listOptions;

        public OrderServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new OrderService();

            this.createOptions = new OrderCreateOptions
            {
                Currency = "usd",
                Items = new List<OrderItemOptions>
                {
                    new OrderItemOptions
                    {
                        Parent = "sku_123",
                        Quantity = 1
                    },
                }
            };

            this.updateOptions = new OrderUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.payOptions = new OrderPayOptions
            {
                CustomerId = "cus_123",
            };

            this.listOptions = new OrderListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var order = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/orders");
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var order = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/orders");
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public void Get()
        {
            var order = this.service.Get(OrderId);
            this.AssertRequest(HttpMethod.Get, "/v1/orders/or_123");
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var order = await this.service.GetAsync(OrderId);
            this.AssertRequest(HttpMethod.Get, "/v1/orders/or_123");
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public void List()
        {
            var orders = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/orders");
            Assert.NotNull(orders);
            Assert.Equal("list", orders.Object);
            Assert.Single(orders.Data);
            Assert.Equal("order", orders.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var orders = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/orders");
            Assert.NotNull(orders);
            Assert.Equal("list", orders.Object);
            Assert.Single(orders.Data);
            Assert.Equal("order", orders.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var orders = this.service.ListAutoPaging(this.listOptions).ToList();
            Assert.NotNull(orders);
            Assert.Equal("order", orders[0].Object);
        }

        [Fact]
        public void Pay()
        {
            var order = this.service.Pay(OrderId, this.payOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/orders/or_123/pay");
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public async Task PayAsync()
        {
            var order = await this.service.PayAsync(OrderId, this.payOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/orders/or_123/pay");
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public void Update()
        {
            var order = this.service.Update(OrderId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/orders/or_123");
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var order = await this.service.UpdateAsync(OrderId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/orders/or_123");
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }
    }
}
