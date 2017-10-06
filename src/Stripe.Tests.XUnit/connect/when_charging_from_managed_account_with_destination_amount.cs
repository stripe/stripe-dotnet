
using System;
using FluentAssertions;
using Xunit;



namespace Stripe.Tests.Xunit
{
    public class when_charging_from_managed_account_with_destination_amount
    {
        private StripeCharge _postCaptureCharge;
        private const int INITIAL_AMOUNT = 10000;
        private const int CAPTURE_AMOUNT = 8000;
        private const int EXPECTED_REFUND_AMOUNT = 2000;
        private const int DESTINATION_CHARGE_AMOUNT = 1000;

        public when_charging_from_managed_account_with_destination_amount()
        {
            var anotherAccount = new StripeAccountService(Cache.ApiKey).Create(new StripeAccountCreateOptions
            {
                DefaultCurrency = "usd",
                Email = "cu_xxxxxx@gmail.com",
                Type = StripeAccountType.Custom
            }
            );

            var chargeService = new StripeChargeService(Cache.ApiKey) { ExpandDestination = true };

            var charge = chargeService.Create(
                new StripeChargeCreateOptions
                {
                    SourceTokenOrExistingSourceId = "tok_visa",
                    Amount = INITIAL_AMOUNT,
                    Currency = "usd",
                    Destination = anotherAccount.Id,
                    Capture = false
                }
            );

            _postCaptureCharge = chargeService.Capture(charge.Id,
                new StripeChargeCaptureOptions()
                {
                    Amount = CAPTURE_AMOUNT,
                    DestinationAmount = DESTINATION_CHARGE_AMOUNT,
                    StatementDescriptor = "Test - Destination Amt"
                });

            
        }

        [Fact]
        public void it_should_have_correct_refund_amount()
        {
            _postCaptureCharge.AmountRefunded.Should().Be(EXPECTED_REFUND_AMOUNT); 
        }
        
        [Fact]
        public void it_should_be_captured()
        {
            _postCaptureCharge.Captured.Should().BeTrue();
        }
    }
}
