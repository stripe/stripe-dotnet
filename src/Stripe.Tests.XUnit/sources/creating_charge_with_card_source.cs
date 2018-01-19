using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_charge_with_card_source
    {
        public StripeSource SourceCard { get; }
        public StripeCharge Charge { get; }

        public creating_charge_with_card_source()
        {
            var sourceCardCreateOptions = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Card,
                Token = "tok_visa",
            };

            var sourceService = new StripeSourceService(Cache.ApiKey);
            SourceCard = sourceService.Create(sourceCardCreateOptions);

            var chargeCreateOptions = new StripeChargeCreateOptions
            {
                Amount = 400,
                Currency = "usd",
                SourceTokenOrExistingSourceId = SourceCard.Id,
            };
            var chargeService = new StripeChargeService(Cache.ApiKey);
            Charge = chargeService.Create(chargeCreateOptions);
        }

        [Fact]
        public void charge_source_should_not_be_null()
        {
            Charge.Should().NotBeNull();
            Charge.Source.Should().NotBeNull();
        }

        [Fact]
        public void charge_source_should_be_the_right_type()
        {
            Charge.Source.Type.Should().Be(SourceType.Source);
        }

        [Fact]
        public void charge_source_object_should_not_be_null()
        {
            Charge.Source.SourceObject.Should().NotBeNull();
        }

        [Fact]
        public void charge_source_object_be_the_right_type()
        {
            Charge.Source.SourceObject.Type.Should().Be(StripeSourceType.Card);
        }

        [Fact]
        public void charge_source_object_card_not_be_null()
        {
            Charge.Source.SourceObject.Card.Should().NotBeNull();
        }

        [Fact]
        public void charge_source_object_card_brand_be_visa()
        {
            Charge.Source.SourceObject.Card.Brand.Should().Be("Visa");
        }
    }
}
