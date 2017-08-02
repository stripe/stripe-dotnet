using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_capturing_a_charge_with_a_card_and_destination_fee
    {
        protected static StripeChargeCreateOptions StripeChargeCreateOptions;
        protected static StripeCharge StripeCharge;
        private static StripeAccount _account;

        private static StripeChargeService _stripeChargeService;

        Establish context = () =>
        {

            // setup a custom (connect) account
            _account = Cache.GetCustomAccountWithCard();
            _stripeChargeService = new StripeChargeService();
            StripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCard();
            StripeChargeCreateOptions.Capture = false;
        };

        private Because of = () =>
        {
            var charge = _stripeChargeService.Create(StripeChargeCreateOptions);
            var captureOptions = test_data.stripe_charge_capture_options.DestinationFee(_account.Id, 665309);
            _stripeChargeService.Capture(charge.Id, captureOptions);

            StripeCharge = _stripeChargeService.Get(charge.Id);
        };

        It should_have_captured_set_to_true = () =>
            StripeCharge.Captured.ShouldEqual(true);
    }
}
