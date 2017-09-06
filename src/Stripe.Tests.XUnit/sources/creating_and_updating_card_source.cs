using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_card_source
    {
        public StripeSourceCreateOptions SourceCardCreateOptions { get; }
        public StripeSourceUpdateOptions SourceCardUpdateOptions { get; }

        public StripeSource SourceCard { get; }
        public StripeSource SourceCardUpdated { get; }

        public creating_and_updating_card_source()
        {
            SourceCardCreateOptions = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Card,
                Token = "tok_visa"
            };

            SourceCardUpdateOptions = new StripeSourceUpdateOptions
            {
                Card = new StripeSourceCardUpdateOptions
                {
                    ExpirationMonth = 12,
                    ExpirationYear = 2028
                }
            };

            var service = new StripeSourceService(Cache.ApiKey);
            SourceCard = service.Create(SourceCardCreateOptions);
            SourceCardUpdated = service.Update(SourceCard.Id, SourceCardUpdateOptions);
        }

        [Fact]
        public void source_should_not_be_null()
        {
            SourceCard.Should().NotBeNull();
            SourceCard.Card.Should().NotBeNull();
        }

        [Fact]
        public void source_should_be_the_right_type()
        {
            SourceCard.Type.Should().Be(SourceCardCreateOptions.Type);
        }

        [Fact]
        public void source_updated_should_have_the_correct_expiration_date()
        {
            SourceCard.Card.ExpirationMonth.Should().Be(SourceCardUpdateOptions.Card.ExpirationMonth);
            SourceCard.Card.ExpirationYear.Should().Be(SourceCardUpdateOptions.Card.ExpirationYear);
        }
    }
}
