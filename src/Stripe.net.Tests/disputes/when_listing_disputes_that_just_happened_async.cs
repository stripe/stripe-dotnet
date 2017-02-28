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

        Establish context = () =>
        {
            var chargeService = new StripeChargeService();
            chargeService.ExpandDispute = true;

            var disputedOptions = test_data.stripe_dispute_options.DisputedCard();

            _stripeChargeOne = chargeService.CreateAsync(disputedOptions).Result;
            _stripeChargeTwo = chargeService.CreateAsync(disputedOptions).Result;

            // we need to wait for Stripe to process the dispute. Try for 10 seconds.
            var stopwatch = Stopwatch.StartNew();
            do
            {
                _stripeChargeOne = chargeService.GetAsync(_stripeChargeOne.Id).Result;
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
                _stripeChargeTwo = chargeService.GetAsync(_stripeChargeTwo.Id).Result;
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

        It should_have_at_least_one_dispute_on_the_first_list = () =>
            _disputeListOne.Count().ShouldBeGreaterThanOrEqualTo(1);

        It should_have_at_lest_one_dispute_on_the_second_list = () =>
            _disputeListTwo.Count().ShouldBeGreaterThanOrEqualTo(1);

        It should_have_the_right_charges_for_the_disputes = () =>
        {
            _disputeListOne.ToList().ShouldContain(c => c.Charge.Id == _stripeChargeOne.Id);
            _disputeListTwo.ToList().ShouldContain(c => c.Charge.Id == _stripeChargeTwo.Id);
        };
    }
}