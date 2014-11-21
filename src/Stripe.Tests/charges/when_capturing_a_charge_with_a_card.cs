using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_capturing_a_charge_with_a_card
    {
        protected static StripeChargeCreateOptions StripeChargeCreateOptions;
        protected static StripeCharge StripeCharge;

        private static StripeChargeService _stripeChargeService;

        Establish context = () =>
        {
            _stripeChargeService = new StripeChargeService();
            StripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCard();
            StripeChargeCreateOptions.Capture = false;
        };

        Because of = () =>
        {
            var charge = _stripeChargeService.Create(StripeChargeCreateOptions);
            _stripeChargeService.Capture(charge.Id);

            StripeCharge = _stripeChargeService.Get(charge.Id);
        };

        It should_have_captured_set_to_true = () =>
            StripeCharge.Captured.ShouldEqual(true);
    }
}
