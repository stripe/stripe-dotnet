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
			StripeCharge charge = _stripeChargeService.Create(StripeChargeCreateOptions).Await();
			_stripeChargeService.Capture(charge.Id).Await();

			StripeCharge = _stripeChargeService.Get(charge.Id).Await();
		};

		It should_have_captured_set_to_true = () =>
			StripeCharge.Captured.ShouldEqual(true);
	}
}
