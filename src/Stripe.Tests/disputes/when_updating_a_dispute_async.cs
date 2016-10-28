using System.Diagnostics;
using System.Threading;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_updating_a_dispute_async
    {
        private static StripeCharge _disputedCharge;
        private static StripeDispute _dispute;

        Establish context = () =>
        {
            var chargeService = new StripeChargeService();
            var disputedOptions = test_data.stripe_dispute_options.DisputedCard();

            var initialCharge = chargeService.Create(disputedOptions);

            // we need to wait for Stripe to process the dispute. Try for 10 seconds.
            var stopwatch = Stopwatch.StartNew();
            do
            {
                _disputedCharge = chargeService.GetAsync(initialCharge.Id).Result;
                if (_disputedCharge.Dispute != null) break;
                Thread.Sleep(500);
            } while (stopwatch.ElapsedMilliseconds < 10000);
        };

        Because of = () =>
        {
            _dispute = new StripeDisputeService().UpdateAsync(_disputedCharge.Dispute.Id, new StripeDisputeUpdateOptions()
            {
                CustomerEmailAddress = "indiana@jones.com"
            }).Result;
        };

        It should_not_be_null = () =>
            _dispute.ShouldNotBeNull();

        It should_have_the_right_email = () =>
            _dispute.Evidence.CustomerEmailAddress.ShouldEqual("indiana@jones.com");
    }
}
