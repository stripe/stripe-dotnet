using System;

namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static StripeCustomer GetCustomer()
        {
            return new StripeCustomerService(ApiKey).Create(GetCustomerCreateOptions());
        }

        public static StripeCustomerCreateOptions GetCustomerCreateOptions()
        {
            var options = new StripeCustomerCreateOptions
            {
                Email = $"{Guid.NewGuid()}@email.com",
                SourceToken = "tok_visa"
            };

            return options;
        }
    }
}
