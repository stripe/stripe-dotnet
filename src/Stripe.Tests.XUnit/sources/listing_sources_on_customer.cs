using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class listing_sources_on_customer
    {
        public StripeList<StripeSource> SourceListAll { get; }
        public StripeList<StripeSource> SourceListCard { get; }
        public StripeList<StripeSource> SourceListACHCredit { get; }

        public listing_sources_on_customer()
        {
            var sourceService = new StripeSourceService(Cache.ApiKey);
            var customerService = new StripeCustomerService(Cache.ApiKey);

            // Create customer
            var CustomerCreateOptions = new StripeCustomerCreateOptions
            {
                Email = "source-list@example.com",
            };
            var Customer = customerService.Create(CustomerCreateOptions);

            // Create card source and attach it to customer
            var SourceCardCreateOptions = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Card,
                Token = "tok_visa"
            };
            var SourceCard = sourceService.Create(SourceCardCreateOptions);

            var SourceAttachOptions = new StripeSourceAttachOptions
            {
                Source = SourceCard.Id
            };
            SourceCard = sourceService.Attach(Customer.Id, SourceAttachOptions);

            // Create ACH Credit Transfer source and attach it to customer
            var SourceACHCreditCreateOptions = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.AchCreditTransfer,
                Currency = "usd",
                Owner = new StripeSourceOwner
                {
                    Email = "amount_4242@example.com",
                },
            };
            var SourceACHCredit = sourceService.Create(SourceACHCreditCreateOptions);

            SourceAttachOptions.Source = SourceACHCredit.Id;
            SourceACHCredit = sourceService.Attach(Customer.Id, SourceAttachOptions);

            // List sources on customer
            SourceListAll = sourceService.List(Customer.Id);

            var SourceListOptions = new StripeSourceListOptions
            {
                Type = StripeSourceType.Card
            };
            SourceListCard = sourceService.List(Customer.Id, SourceListOptions);

            SourceListOptions.Type = StripeSourceType.AchCreditTransfer;
            SourceListACHCredit = sourceService.List(Customer.Id, SourceListOptions);
        }

        [Fact]
        public void list_all_should_have_both_sources()
        {
            SourceListAll.Data.Count.Should().Be(2);

            var SourceCard = SourceListAll.Data[0];
            SourceCard.Type.Should().Be(StripeSourceType.Card);
            SourceCard.Card.Brand.Should().Be("Visa");

            var SourceACHCredit = SourceListAll.Data[1];
            SourceACHCredit.Type.Should().Be(StripeSourceType.AchCreditTransfer);
            SourceACHCredit.AchCreditTransfer.AccountNumber.Should().NotBeNull();
        }

        [Fact]
        public void list_card_should_have_card_source()
        {
            SourceListCard.Data.Count.Should().Be(1);

            var SourceCard = SourceListCard.Data[0];
            SourceCard.Type.Should().Be(StripeSourceType.Card);
            SourceCard.Card.Brand.Should().Be("Visa");
        }

        [Fact]
        public void list_ach_credit_should_have_ach_credit_source()
        {
            SourceListACHCredit.Data.Count.Should().Be(1);

            var SourceACHCredit = SourceListACHCredit.Data[0];
            SourceACHCredit.Type.Should().Be(StripeSourceType.AchCreditTransfer);
            SourceACHCredit.AchCreditTransfer.AccountNumber.Should().NotBeNull();
        }
    }
}
