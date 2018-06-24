using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_updating_and_capturing_charges : IClassFixture<charges_fixture>
    {
        private readonly charges_fixture fixture;

        public creating_updating_and_capturing_charges(charges_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void shipping_is_not_null()
        {
            fixture.Charge.Shipping.Should().NotBeNull();
        }

        [Fact]
        public void shipping_has_the_right_name()
        {
            fixture.Charge.Shipping.Name.Should().Be(Cache.GetStripeChargeCreateOptions().Shipping.Name);
        }

        [Fact]
        public void shipping_address_is_not_null()
        {
            fixture.Charge.Shipping.Address.Should().NotBeNull();
        }

        [Fact]
        public void shipping_has_the_right_line1()
        {
            fixture.Charge.Shipping.Address.Line1.Should().Be(Cache.GetStripeChargeCreateOptions().Shipping.Line1);
        }

        [Fact]
        public void shipping_has_the_right_line2()
        {
            fixture.Charge.Shipping.Address.Line2.Should().Be(Cache.GetStripeChargeCreateOptions().Shipping.Line2);
        }

        [Fact]
        public void shipping_has_the_right_country()
        {
            fixture.Charge.Shipping.Address.Country.Should().Be(Cache.GetStripeChargeCreateOptions().Shipping.Country);
        }

        [Fact]
        public void shipping_has_the_right_state()
        {
            fixture.Charge.Shipping.Address.State.Should().Be(Cache.GetStripeChargeCreateOptions().Shipping.State);
        }

        [Fact]
        public void shipping_has_the_right_carrier()
        {
            fixture.Charge.Shipping.Carrier.Should().Be(Cache.GetStripeChargeCreateOptions().Shipping.Carrier);
        }

        [Fact]
        public void shipping_has_the_right_tracking_number()
        {
            fixture.Charge.Shipping.TrackingNumber.Should().Be(Cache.GetStripeChargeCreateOptions().Shipping.TrackingNumber);
        }

        [Fact]
        public void charge_has_outcome_filled()
        {
            fixture.Charge.Outcome.NetworkStatus.Should().NotBeNull();
            fixture.Charge.Outcome.RiskLevel.Should().NotBeNull();
        }

        [Fact]
        public void updated_has_the_right_description()
        {
            fixture.UpdatedCharge.Description.Should().Be(fixture.ChargeUpdateOptions.Description);
        }

        [Fact]
        public void updated_shipping_has_the_right_phone()
        {
            fixture.UpdatedCharge.Shipping.Phone.Should().Be(fixture.ChargeUpdateOptions.Shipping.Phone);
        }

        public void updated_shipping_has_the_right_tracking_number()
        {
            fixture.UpdatedCharge.Shipping.TrackingNumber.Should().Be(fixture.ChargeUpdateOptions.Shipping.TrackingNumber);
        }

        [Fact]
        public void uncaptured_is_not_captured()
        {
            fixture.UncapturedCharge.Captured.Should().Be(false);
        }

        [Fact]
        public void captured_is_captured_with_right_settings()
        {
            fixture.CapturedCharge.Captured.Should().Be(true);
            fixture.CapturedCharge.StatementDescriptor.Should().Be(fixture.ChargeCaptureOptions.StatementDescriptor);
            Assert.Equal(fixture.CapturedCharge.Amount - fixture.CapturedCharge.AmountRefunded, fixture.ChargeCaptureOptions.Amount);
        }

        [Fact]
        public void charge_level3_is_not_null()
        {
            fixture.Level3Charge.Should().NotBeNull();
        }
    }
}
