using System.Diagnostics;
using System.Threading;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_disputed_charge_async
    {
        private static StripeChargeService _chargeService;
        private static StripeChargeCreateOptions _disputedOptions;
        private static StripeCharge _initialCharge;
        private static StripeCharge _disputedCharge;

        Establish context = () =>
        {
            _chargeService = new StripeChargeService();
            _chargeService.ExpandDispute = true;

            _disputedOptions = test_data.stripe_dispute_options.DisputedCard();

            _initialCharge = _chargeService.CreateAsync(_disputedOptions).Result;
        };

        Because of = () =>
        {
            // we need to wait for Stripe to process the dispute. Try for 10 seconds.
            var stopwatch = Stopwatch.StartNew();
            do
            {
                _disputedCharge = _chargeService.GetAsync(_initialCharge.Id).Result;
                if (_disputedCharge.Dispute != null) break;
                Thread.Sleep(500);
            } while (stopwatch.ElapsedMilliseconds < 10000);
        };

        It should_have_dispute_defined = () =>
            _disputedCharge.Dispute.ShouldNotBeNull();

        It should_have_dispute_evidence = () =>
            _disputedCharge.Dispute.Evidence.ShouldNotBeNull();

        It should_have_disputed_evidence_details_defined = () =>
            _disputedCharge.Dispute.EvidenceDetails.ShouldNotBeNull();

        // this isn't always present, but with the test card it is
        It should_have_the_disputed_evidence_details_dueby = () =>
            _disputedCharge.Dispute.EvidenceDetails.DueBy.ShouldNotBeNull();

        It should_have_the_disputed_evidence_details_hasevidence_as_false = () =>
            _disputedCharge.Dispute.EvidenceDetails.HasEvidence.ShouldBeFalse();

        It should_have_the_disputed_evidence_details_pastdue_as_false = () =>
            _disputedCharge.Dispute.EvidenceDetails.PastDue.ShouldBeFalse();

        It should_have_the_disputed_evidence_details_submissioncount_as_zero = () =>
            _disputedCharge.Dispute.EvidenceDetails.SubmissionCount.ShouldEqual(0);
    }
}
