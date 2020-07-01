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
        private readonly OrderReturnOptions returnOptions;
        private readonly OrderListOptions listOptions;

        public OrderServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new OrderService(this.StripeClient);

            this.createOptions = new OrderCreateOptions
            {
                Currency = "usd",
                Items = new List<OrderItemOptions>
                {
                    new OrderItemOptions
                    {
                        Parent = "sku_123",
                        Quantity = 1,
                    },
                },
            };

            this.listOptions = new OrderListOptions
            {
                Limit = 1,
            };

            this.payOptions = new OrderPayOptions
            {
                Customer = "cus_123",
            };

            this.returnOptions = new OrderReturnOptions
            {
                Items = new List<OrderReturnItemOptions>
                {
                    new OrderReturnItemOptions
                    {
                        Parent = "sku_123",
                        Quantity = 1,
                    },
                },
            };

            this.updateOptions = new OrderUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
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
            var order = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var order = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
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
        public void Return()
        {
            var orderReturn = this.service.Return(OrderId, this.returnOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/orders/or_123/returns");
            Assert.NotNull(orderReturn);
            Assert.Equal("order_return", orderReturn.Object);
        }

        [Fact]
        public async Task ReturnAsync()
        {
            var orderReturn = await this.service.ReturnAsync(OrderId, this.returnOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/orders/or_123/returns");
            Assert.NotNull(orderReturn);
            Assert.Equal("order_return", orderReturn.Object);
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
