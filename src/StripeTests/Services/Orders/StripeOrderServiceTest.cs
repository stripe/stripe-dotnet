namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class StripeOrderServiceTest : BaseStripeTest
    {
        private const string OrderId = "or_123";

        private StripeOrderService service;
        private StripeOrderCreateOptions createOptions;
        private StripeOrderUpdateOptions updateOptions;
        private StripeOrderPayOptions payOptions;
        private StripeOrderListOptions listOptions;

        public StripeOrderServiceTest()
        {
            this.service = new StripeOrderService();

            this.createOptions = new StripeOrderCreateOptions()
            {
                Currency = "usd",
                Items = new List<StripeOrderItemOptions>
                {
                    new StripeOrderItemOptions
                    {
                        Parent = "sku_123",
                        Quantity = 1
                    },
                }
            };

            this.updateOptions = new StripeOrderUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.payOptions = new StripeOrderPayOptions()
            {
                CustomerId = "cus_123",
            };

            this.listOptions = new StripeOrderListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var order = this.service.Create(this.createOptions);
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var order = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public void Get()
        {
            var order = this.service.Get(OrderId);
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var order = await this.service.GetAsync(OrderId);
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public void List()
        {
            var orders = this.service.List(this.listOptions);
            Assert.NotNull(orders);
            Assert.Equal("list", orders.Object);
            Assert.Single(orders.Data);
            Assert.Equal("order", orders.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var orders = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(orders);
            Assert.Equal("list", orders.Object);
            Assert.Single(orders.Data);
            Assert.Equal("order", orders.Data[0].Object);
        }

        [Fact]
        public void Pay()
        {
            var order = this.service.Pay(OrderId, this.payOptions);
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public async Task PayAsync()
        {
            var order = await this.service.PayAsync(OrderId, this.payOptions);
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public void Update()
        {
            var order = this.service.Update(OrderId, this.updateOptions);
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var order = await this.service.UpdateAsync(OrderId, this.updateOptions);
            Assert.NotNull(order);
            Assert.Equal("order", order.Object);
        }
    }
}
