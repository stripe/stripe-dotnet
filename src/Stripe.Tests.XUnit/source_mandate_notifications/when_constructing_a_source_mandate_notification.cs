using System;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class when_constructing_a_source_mandate_notification : IClassFixture<source_mandate_notifications_fixture>
    {
        private readonly source_mandate_notifications_fixture fixture;
        public StripeSourceMandateNotification Notification { get; set; }

        public when_constructing_a_source_mandate_notification(source_mandate_notifications_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void it_should_load_the_right_data()
        {
            Notification = Mapper<StripeSourceMandateNotification>.MapFromJson(fixture.StripeJson);

            Notification.Should().NotBeNull();
            Notification.Id.Should().Be("srcmn_1234");
            Notification.Object.Should().Be("source_mandate_notification");
            Notification.Amount.Should().Be(1000);
            Notification.LiveMode.Should().Be(false);
            Notification.Reason.Should().Be("debit_initiated");
            Notification.Status.Should().Be("pending");
            Notification.Type.Should().Be("sepa_debit");
            Notification.Source.Id.Should().Be("src_123");
            Notification.Source.Type.Should().Be("sepa_debit");
            Notification.SepaDebit.CreditorIdentifier.Should().Be("TEST111111111111111");
            Notification.SepaDebit.MandateReference.Should().Be("OAAAAAAAAAAAAAAO");
            Notification.SepaDebit.Last4.Should().Be("3000");
        }
    }
}
