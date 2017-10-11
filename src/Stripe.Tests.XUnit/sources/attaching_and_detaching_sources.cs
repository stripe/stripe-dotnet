using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class attaching_and_detaching_sources
    {
        public StripeCustomer Customer { get; }
        public StripeSource SourceAttached { get; }
        public StripeSource SourceDetached { get; }

        public attaching_and_detaching_sources()
        {
            var SourceCardCreateOptions = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Card,
                Token = "tok_visa"
            };

            var CustomerCreateOptions = new StripeCustomerCreateOptions
            {
                Email = "source-attach-detach@example.com",
            };

            var sourceService = new StripeSourceService(Cache.ApiKey);
            var customerService = new StripeCustomerService(Cache.ApiKey);

            var SourceCard = sourceService.Create(SourceCardCreateOptions);
            Customer = customerService.Create(CustomerCreateOptions);

            var SourceAttachOptions = new StripeSourceAttachOptions
            {
                Source = SourceCard.Id
            };

            SourceAttached = sourceService.Attach(Customer.Id, SourceAttachOptions);
            SourceDetached = sourceService.Detach(Customer.Id, SourceAttached.Id);
        }

        [Fact]
        public void source_attached_should_not_be_null()
        {
            SourceAttached.Should().NotBeNull();
        }

        [Fact]
        public void source_attached_should_have_the_correct_customer_id()
        {
            SourceAttached.Customer.Should().Be(Customer.Id);
        }

        [Fact]
        public void source_detached_should_not_be_null()
        {
            SourceDetached.Should().NotBeNull();
        }

        [Fact]
        public void source_detached_should_not_have_a_customer_id()
        {
            SourceDetached.Customer.Should().BeNull();
        }
    }
}
