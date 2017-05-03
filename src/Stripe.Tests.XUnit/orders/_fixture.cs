using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public class orders_fixture
    {
        public StripeOrderCreateOptions OrderCreateOptions { get; }
        //public StripePayoutUpdateOptions PayoutUpdateOptions { get; }
        //public StripePayoutListOptions PayoutListOptions { get; }

        public StripeOrder Order { get; }
        //public StripePayout PayoutUpdated { get; }
        //public StripePayout PayoutRetrieved { get; }
        //public List<StripePayout> PayoutList { get; }

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

            //PayoutUpdateOptions = new StripePayoutUpdateOptions
            //{
            //    Metadata = new Dictionary<string, string>()
            //    {
            //        { "some-key", "some-value" }
            //    }
            //};

            var service = new StripeOrderService(Cache.ApiKey);
            Order = service.Create(OrderCreateOptions);
            //PayoutUpdated = service.Update(Payout.Id, PayoutUpdateOptions);
            //PayoutRetrieved = service.Get(Payout.Id);

            //PayoutListOptions = new StripePayoutListOptions
            //{
            //    Created = Payout.Created,
            //    ArrivalDate = Payout.ArrivalDate
            //};

            //PayoutList = service.List(PayoutListOptions).ToList();
        }
    }
}
