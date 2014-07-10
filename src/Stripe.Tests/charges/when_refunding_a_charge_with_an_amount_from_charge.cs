using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_refunding_a_charge_with_an_amount_from_charge
	{
		private static StripeChargeCreateOptions _stripeChargeCreateOptions;
        private static StripeRefundCreateOptions _stripeRefundCreateOptions;
        private static StripeCharge _stripeCharge;
		private static StripeChargeService _stripeChargeService;

		Establish context = () =>
		{
			_stripeChargeService = new StripeChargeService();
			_stripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCard();
            _stripeRefundCreateOptions = test_data.stripe_refund_create_options.PartialRefundWithoutApplicationFee();

            _stripeCharge = _stripeChargeService.Create(_stripeChargeCreateOptions);
		};

		Because of = () =>
            _stripeCharge.Refund(_stripeRefundCreateOptions);

		It should_have_the_correct_amount_refunded = () =>
            _stripeCharge.AmountRefunded.ShouldEqual(10);
	}
}