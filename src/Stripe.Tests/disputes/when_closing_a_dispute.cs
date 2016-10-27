using System.Diagnostics;
using System.Threading;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_closing_a_dispute
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
                _disputedCharge = chargeService.Get(initialCharge.Id);
                if (_disputedCharge.Dispute != null) break;
                Thread.Sleep(500);
            } while (stopwatch.ElapsedMilliseconds < 10000);
        };

        Because of = () =>
        {
            _dispute = new StripeDisputeService().Close(_disputedCharge.Dispute.Id);
        };

        It should_be_lost = () =>
            _dispute.Status.ShouldEqual("lost");
    }
}
