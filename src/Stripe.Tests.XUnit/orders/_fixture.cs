using System;

namespace Stripe.Tests.Xunit
{
    public class order_fixture : IDisposable
    {

        public StripeOrder Order { get; }
        public StripeOrderCreateOptions OrderCreateOptions { get; set; }

        public order_fixture()
        {
            Order = Cache.GetOrder();
            OrderCreateOptions = Cache.GetOrderCreateOptions();
        }

        public void Dispose()
        {
        }
    }
}
