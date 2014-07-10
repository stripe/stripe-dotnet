using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_refunding_a_charge_with_an_amount_from_charge_service
	{
		private static StripeChargeCreateOptions _stripeChargeCreateOptions;
        private static StripeCharge _stripeCharge;
		private static StripeChargeService _stripeChargeService;

		Establish context = () =>
		{
			_stripeChargeService = new StripeChargeService();
			_stripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCard();

            _stripeCharge = _stripeChargeService.Create(_stripeChargeCreateOptions);
		};

		Because of = () =>
            _stripeCharge.Refund(10);

		It should_have_the_correct_amount_refunded = () =>
            _stripeCharge.AmountRefunded.ShouldEqual(10);
	}
}