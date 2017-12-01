using System.Collections.Generic;
using System.Linq;

namespace Stripe.Tests.Xunit
{
    public class orders_fixture
    {
        public StripeOrderCreateOptions OrderCreateOptions { get; }
        public StripeOrderUpdateOptions OrderUpdateOptions { get; }
        public StripeOrderListOptions OrderListOptions { get; }
        public StripeOrderPayOptions OrderPayOptions { get; }

        public StripeOrder Order { get; }
        public StripeOrder OrderUpdated { get; }
        public StripeOrder OrderRetrieved { get; }
        public StripeOrder OrderPaid { get; }
        public StripeList<StripeOrder> OrderList { get; }

        public orders_fixture()
        {
            var productService = new StripeProductService(Cache.ApiKey);
            var product = productService.Create(new StripeProductCreateOptions {
                Name = "T-shirt",
                Type = "good"
            });

            var skuService = new StripeSkuService(Cache.ApiKey);
            var sku = skuService.Create(new StripeSkuCreateOptions
            {
                Currency = "usd",
                Inventory = new StripeInventoryOptions {
                    Type = "infinite",
                },
                Price = 1234,
                Product = product.Id
            });

            OrderCreateOptions = new StripeOrderCreateOptions()
            {
                Currency = "usd",
                Items = new List<StripeOrderItemOptions>
                {
                    new StripeOrderItemOptions
                    {
                        Amount = 1,
                        Description = "Blue Shirts",
                        Parent = sku.Id,
                        Quantity = 1
                    },
                },
                Shipping = new StripeShippingOptions
                {
                    Name = "Namey Namerson",
                    Line1 = "123 Main St"
                }
            };

            OrderUpdateOptions = new StripeOrderUpdateOptions
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "some-key", "some-value" }
                }
            };

            var customer = Cache.GetCustomer();

            OrderPayOptions = new StripeOrderPayOptions
            {
                SourceId = "tok_visa",
                Email = customer.Email,
            };

            var service = new StripeOrderService(Cache.ApiKey);
            Order = service.Create(OrderCreateOptions);
            OrderUpdated = service.Update(Order.Id, OrderUpdateOptions);
            OrderRetrieved = service.Get(Order.Id);
            OrderPaid = service.Pay(Order.Id, OrderPayOptions);

            OrderListOptions = new StripeOrderListOptions()
            {
                Created = Order.Created
            };

            OrderList = service.List(OrderListOptions);
        }
    }
}
