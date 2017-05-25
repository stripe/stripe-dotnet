using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_updating_a_dispute
    {
        private static StripeCharge _disputedCharge;
        private static StripeDispute _dispute;
        private static StripeDisputeUpdateOptions _updateOptions;

        Establish context = () =>
        {
            var chargeService = new StripeChargeService();
            chargeService.ExpandDispute = true;

            var disputedOptions = test_data.stripe_dispute_options.DisputedCard();

            var initialCharge = chargeService.Create(disputedOptions);

            // we need to wait for Stripe to process the dispute. Try for 10 seconds.
            var stopwatch = Stopwatch.StartNew();
            do
            {
                _disputedCharge = chargeService.Get(initialCharge.Id);
                if (_disputedCharge.Dispute != null) break;
                Thread.Sleep(500);
            } while (stopwatch.ElapsedMilliseconds < 10000);

            _updateOptions = new StripeDisputeUpdateOptions
            {
                CustomerEmailAddress = "indiana@jones.com",
                Metadata = new Dictionary<string, string>
                {
                    { "diary", "i wrote them down in my diary so i wouldn't have to remember" }
                }
            };
        };

        Because of = () =>
        {
            _dispute = new StripeDisputeService().Update(_disputedCharge.Dispute.Id, _updateOptions);
        };

        It should_not_be_null = () =>
            _dispute.ShouldNotBeNull();

        It should_have_the_right_email = () =>
            _dispute.Evidence.CustomerEmailAddress.ShouldEqual("indiana@jones.com");

        It should_have_the_right_metadata = () =>
            _dispute.Metadata.ShouldEqual(_updateOptions.Metadata);
    }
}
