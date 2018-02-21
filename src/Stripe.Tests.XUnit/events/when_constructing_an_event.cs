using System;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class when_constructing_an_event : IClassFixture<events_fixture>
    {
        private readonly events_fixture fixture;
        public StripeEvent ConstructedEvent { get; set; }

        public when_constructing_an_event(events_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void it_should_throw_with_outdated_timestamp()
        {
            // This throws an error because the tolerance is higher than allowed
            var exception = Assert.Throws<StripeException>(() =>
                StripeEventUtility.ConstructEvent(fixture.StripeJson, fixture.StripeSignature, fixture.StripeSecret)
            );

            exception.Message.Should().Be("The webhook cannot be processed because the current timestamp is above the allowed tolerance.");
        }

        [Fact]
        public void it_should_validate_with_right_data()
        {
            // A timestamp within the default tolerance of 300 seconds
            int ReasonablyCloseTime = fixture.EventTimestamp + 120;

            ConstructedEvent = StripeEventUtility.ConstructEvent(fixture.StripeJson, fixture.StripeSignature, fixture.StripeSecret, ReasonablyCloseTime);

            ConstructedEvent.Should().NotBeNull();
            ConstructedEvent.Request.Id.Should().Be("req_FAKE");
            ConstructedEvent.Request.IdempotencyKey.Should().Be("placeholder");
            ConstructedEvent.Account.Should().Be("acct_CONNECT");
        }

        [Fact]
        public void it_should_throw_with_incorrect_signature()
        {
            // This throws an error because the original JSON message is modified
            var exception = Assert.Throws<StripeException>(() =>
                StripeEventUtility.ConstructEvent(fixture.StripeJson + "this_changes_the_json", fixture.StripeSignature, fixture.StripeSecret)
            );

            exception.Message.Should().Be("The signature for the webhook is not present in the Stripe-Signature header.");
        }

        [Fact]
        public void it_should_throw_with_invalid_unicode_in_secret()
        {
            var exception = Assert.Throws<StripeException>(() =>
                StripeEventUtility.ConstructEvent(fixture.StripeJson, fixture.StripeSignature, fixture.StripeSecret + "\ud802")
            );

            exception.Message.Should().Be("The webhook cannot be processed because the signature cannot be safely calculated.");
        }

        [Fact]
        public void it_should_throw_with_invalid_unicode_in_message()
        {
            var exception = Assert.Throws<StripeException>(() =>
                StripeEventUtility.ConstructEvent(fixture.StripeJson + "\ud802", fixture.StripeSignature, fixture.StripeSecret)
            );

            exception.Message.Should().Be("The webhook cannot be processed because the signature cannot be safely calculated.");
        }
    }
}
