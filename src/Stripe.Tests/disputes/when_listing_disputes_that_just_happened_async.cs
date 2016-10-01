using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_disputes_that_just_happened_async
    {
        private static StripeCharge _stripeChargeOne;
        private static StripeCharge _stripeChargeTwo;
        private static IEnumerable<StripeDispute> _disputeListOne;
        private static IEnumerable<StripeDispute> _disputeListTwo;

        private static StripeDispute _disputedChargeOne;
        private static StripeDispute _disputedChargeTwo;

        private Establish context = () =>
        {
            var chargeService = new StripeChargeService();
            var disputedOptions = test_data.stripe_dispute_options.DisputedCard();

            _stripeChargeOne = chargeService.Create(disputedOptions);
            _stripeChargeTwo = chargeService.Create(disputedOptions);

            // we need to wait for Stripe to process the dispute. Try for 10 seconds.
            var stopwatch = Stopwatch.StartNew();
            do
            {
                _stripeChargeOne = chargeService.Get(_stripeChargeOne.Id);
                if (_stripeChargeOne.Dispute != null)
                {
                    _disputedChargeOne = _stripeChargeOne.Dispute;
                    break;
                }
                Thread.Sleep(500);
            } while (stopwatch.ElapsedMilliseconds < 10000);

            stopwatch = Stopwatch.StartNew();
            do
            {
                _stripeChargeTwo = chargeService.Get(_stripeChargeTwo.Id);
                if (_stripeChargeTwo.Dispute != null)
                {
                    _disputedChargeTwo = _stripeChargeTwo.Dispute;
                    break;
                }
                Thread.Sleep(500);
            } while (stopwatch.ElapsedMilliseconds < 10000);
        };

        Because of = () =>
        {
            var firstDisputeTimeFilter = new StripeDateFilter { EqualTo = _disputedChargeOne.Created };
            var secondDisputeTimeFilter = new StripeDateFilter { EqualTo = _disputedChargeTwo.Created };

            _disputeListOne = new StripeDisputeService { ExpandCharge = true }.ListAsync(new StripeDisputeListOptions { Created = firstDisputeTimeFilter }).Result;
            _disputeListTwo = new StripeDisputeService { ExpandCharge = true }.ListAsync(new StripeDisputeListOptions { Created = secondDisputeTimeFilter }).Result;
        };

        It should_have_only_one_dispute_on_the_first_list = () =>
            _disputeListOne.Count().ShouldEqual(1);

        It should_have_only_one_dispute_on_the_second_list = () =>
            _disputeListTwo.Count().ShouldEqual(1);

        It should_have_the_right_charges_for_the_disputes = () =>
        {
            _disputeListOne.First().Charge.Id.ShouldEqual(_stripeChargeOne.Id);
            _disputeListTwo.First().Charge.Id.ShouldEqual(_stripeChargeTwo.Id);
        };
    }
}