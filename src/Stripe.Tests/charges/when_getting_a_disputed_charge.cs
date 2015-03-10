using System.Diagnostics;
using System.Threading;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_disputed_charge
    {
        protected static StripeChargeCreateOptions StripeChargeCreateOptions;
        protected static StripeCharge StripeCharge;
        protected static StripeCard StripeCard;

        private static StripeChargeService _stripeChargeService;
        private static string _createdStripeChargeId;

        Establish context = () =>
        {
            _stripeChargeService = new StripeChargeService();
            StripeChargeCreateOptions = test_data.stripe_charge_create_options.DisputedCard();

            var stripeCharge = _stripeChargeService.Create(StripeChargeCreateOptions);
            _createdStripeChargeId = stripeCharge.Id;
        };

        Because of = () =>
        {
            var stopwatch = Stopwatch.StartNew();
            do
            {
                StripeCharge = _stripeChargeService.Get(_createdStripeChargeId);
                StripeCard = StripeCharge.StripeCard;
                if (StripeCharge.Dispute != null) break;
                Thread.Sleep(500);
            } while (stopwatch.ElapsedMilliseconds < 10000);
        };

        Behaves_like<charge_behaviors> behaviors;

        It should_have_dispute_defined = () =>
            StripeCharge.Dispute.ShouldNotBeNull();
    }
}