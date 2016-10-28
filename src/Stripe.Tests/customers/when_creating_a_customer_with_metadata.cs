using System;
using System.Collections.Generic;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_customer_with_metadata
    {
        private static StripeCustomerService _customerService;
        private static StripeCustomer _createdCustomer;
        private static StripeCustomer _updatedCustomer;

        Establish context = () =>
        {
            _customerService = new StripeCustomerService();

            var options = new StripeCustomerCreateOptions()
            {
                Email = $"lollipop_guild_+{Guid.NewGuid()}@email.com",
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" },
                    { "C", "Not messing with this" }
                }
            };

            _createdCustomer = _customerService.Create(options);
        };

        Because of = () =>
        {
            _updatedCustomer = _customerService.Update(_createdCustomer.Id, new StripeCustomerUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "A", null },
                    { "B", string.Empty }
                }
            });
        };

        It should_have_only_one_metadata_entry = () =>
            _updatedCustomer.Metadata.Count.ShouldEqual(1);

        It should_have_only_the_c_metadata = () =>
            _updatedCustomer.Metadata.Keys.ShouldContain("C");
    }
}