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
        public List<StripeOrder> OrderList { get; }

        public orders_fixture()
        {
            OrderCreateOptions = new StripeOrderCreateOptions()
            {
                Currency = "usd",
                Items = new List<StripeOrderItemOptions>
                {
                    new StripeOrderItemOptions
                    {
                        Amount = 1,
                        Description = "some random items in a furry sack",
                        Parent = "sku_AafhRMBaimSiAO", // i hardcoded this because skus isn't written yet. created from the dashboard
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
                SourceId = Cache.GetToken().Id,
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

            OrderList = service.List(OrderListOptions).ToList();
        }
    }
}
