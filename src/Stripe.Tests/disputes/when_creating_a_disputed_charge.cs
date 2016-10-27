using System.Diagnostics;
using System.Threading;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_disputed_charge
    {
        private static StripeChargeService _chargeService;
        private static StripeChargeCreateOptions _disputedOptions;
        private static StripeCharge _initialCharge;
        private static StripeCharge _disputedCharge;

        Establish context = () =>
        {
            _chargeService = new StripeChargeService();
            _disputedOptions = test_data.stripe_dispute_options.DisputedCard();

            _initialCharge = _chargeService.Create(_disputedOptions);
        };

        Because of = () =>
        {
            // we need to wait for Stripe to process the dispute. Try for 10 seconds.
            var stopwatch = Stopwatch.StartNew();
            do
            {
                _disputedCharge = _chargeService.Get(_initialCharge.Id);
                if (_disputedCharge.Dispute != null) break;
                Thread.Sleep(500);
            } while (stopwatch.ElapsedMilliseconds < 10000);
        };

        It should_have_dispute_defined = () =>
            _disputedCharge.Dispute.ShouldNotBeNull();

        It should_have_dispute_evidence = () =>
            _disputedCharge.Dispute.Evidence.ShouldNotBeNull();

        It should_have_the_right_addressline1_on_dispute_evidence = () =>
            _disputedCharge.Dispute.Evidence.BillingAddress.ShouldContain(_disputedOptions.SourceCard.AddressLine1);

        It should_have_the_right_addressline2_on_dispute_evidence = () =>
            _disputedCharge.Dispute.Evidence.BillingAddress.ShouldContain(_disputedOptions.SourceCard.AddressLine2);

        It should_have_the_right_city_on_dispute_evidence = () =>
            _disputedCharge.Dispute.Evidence.BillingAddress.ShouldContain(_disputedOptions.SourceCard.AddressCity);

        It should_have_the_right_state_on_dispute_evidence = () =>
            _disputedCharge.Dispute.Evidence.BillingAddress.ShouldContain(_disputedOptions.SourceCard.AddressState);

        It should_have_the_right_country_on_dispute_evidence = () =>
            _disputedCharge.Dispute.Evidence.BillingAddress.ShouldContain(_disputedOptions.SourceCard.AddressCountry);

        It should_have_the_right_zip_on_dispute_evidence = () =>
            _disputedCharge.Dispute.Evidence.BillingAddress.ShouldContain(_disputedOptions.SourceCard.AddressZip);

        It should_have_the_right_customer_name_on_dispute_evidence = () =>
            _disputedCharge.Dispute.Evidence.CustomerName.ShouldEqual(_disputedOptions.SourceCard.Name);

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
