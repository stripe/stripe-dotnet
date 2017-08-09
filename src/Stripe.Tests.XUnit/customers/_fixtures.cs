using System;

namespace Stripe.Tests.Xunit
{
    public class customers_fixture : IDisposable
    {
        public StripeCustomerCreateOptions CustomerCreateOptionsWithShipping { get; set; }
        public StripeCustomerUpdateOptions CustomerUpdateOptionsWithShipping { get; set; }

        public StripeCustomer CustomerWithShipping { get; set; }
        public StripeCustomer UpdatedCustomerWithShipping { get; set; }

        public customers_fixture()
        {
            CustomerCreateOptionsWithShipping = new StripeCustomerCreateOptions
            {
                Email = "createemail@example.com",
                SourceToken = "tok_visa",
                Shipping = new StripeShippingOptions
                {
                    Name = "Namey Namerson",
                    Line1 = "123 Main St",
                    Line2 = "Apt B",
                    Country = "USA",
                    State = "NC",
                }
            };

            var service = new StripeCustomerService(Cache.ApiKey);
            CustomerWithShipping = service.Create(CustomerCreateOptionsWithShipping);

            CustomerUpdateOptionsWithShipping = new StripeCustomerUpdateOptions
            {
                Email = "updatedemail@example.com",
                Shipping = CustomerCreateOptionsWithShipping.Shipping
            };
            CustomerUpdateOptionsWithShipping.Shipping.Phone = "8675309";

            UpdatedCustomerWithShipping = service.Update(CustomerWithShipping.Id, CustomerUpdateOptionsWithShipping);
        }

        public void Dispose() { }
    }
}
