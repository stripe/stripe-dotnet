using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class listing_sources_on_customer
    {
        public StripeList<StripeSource> SourceListAll { get; }
        public StripeList<StripeSource> SourceListCard { get; }
        public StripeList<StripeSource> SourceListBitcoin { get; }

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

            // Create bitcoin source and attach it to customer
            var SourceBitcoinCreateOptions = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Bitcoin,
                Amount = 1000,
                Currency = "usd",
                Owner = new StripeSourceOwner
                {
                    Email = "jenny.rosen+fill_now@example.com",
                },
            };
            var SourceBitcoin = sourceService.Create(SourceBitcoinCreateOptions);

            SourceAttachOptions.Source = SourceBitcoin.Id;
            SourceBitcoin = sourceService.Attach(Customer.Id, SourceAttachOptions);

            // List sources on customer
            SourceListAll = sourceService.List(Customer.Id);

            var SourceListOptions = new StripeSourceListOptions
            {
                Type = StripeSourceType.Card
            };
            SourceListCard = sourceService.List(Customer.Id, SourceListOptions);

            SourceListOptions.Type = StripeSourceType.Bitcoin;
            SourceListBitcoin = sourceService.List(Customer.Id, SourceListOptions);
        }

        [Fact]
        public void list_all_should_have_both_sources()
        {
            SourceListAll.Data.Count.Should().Be(2);

            var SourceCard = SourceListAll.Data[0];
            SourceCard.Type.Should().Be(StripeSourceType.Card);
            SourceCard.Card.Brand.Should().Be("Visa");

            var SourceBitcoin = SourceListAll.Data[1];
            SourceBitcoin.Type.Should().Be(StripeSourceType.Bitcoin);
            SourceBitcoin.Bitcoin.Address.Should().NotBeNull();
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
        public void list_bitcoin_should_have_bitcoin_source()
        {
            SourceListBitcoin.Data.Count.Should().Be(1);

            var SourceBitcoin = SourceListBitcoin.Data[0];
            SourceBitcoin.Type.Should().Be(StripeSourceType.Bitcoin);
            SourceBitcoin.Bitcoin.Address.Should().NotBeNull();
        }
    }
}
