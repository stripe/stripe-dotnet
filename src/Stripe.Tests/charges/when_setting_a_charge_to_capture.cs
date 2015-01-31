using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_setting_a_charge_to_capture
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
            StripeCharge = _stripeChargeService.Create(StripeChargeCreateOptions);
        };

        It should_have_captured_set_to_false = () =>
            StripeCharge.Captured.ShouldEqual(false);
    }
}
