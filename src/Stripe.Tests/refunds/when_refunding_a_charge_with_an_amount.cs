using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_refunding_a_charge_with_an_amount
	{
		private static StripeChargeCreateOptions _stripeChargeCreateOptions;
        private static StripeRefundCreateOptions _stripeRefundCreateOptions;
		private static StripeRefund _stripeRefund;
		private static StripeChargeService _stripeChargeService;
        private static StripeRefundService _stripeRefundService;
		private static string _createdStripeChargeId;

		Establish context = () =>
		{
			_stripeChargeService = new StripeChargeService();
            _stripeRefundService = new StripeRefundService();
			_stripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCard();
            _stripeRefundCreateOptions = test_data.stripe_refund_create_options.PartialRefundWithoutApplicationFee();

			var stripeCharge = _stripeChargeService.Create(_stripeChargeCreateOptions);
			_createdStripeChargeId = stripeCharge.Id;
		};

		Because of = () =>
            _stripeRefund = _stripeRefundService.Create(_createdStripeChargeId, _stripeRefundCreateOptions);

		It should_have_the_correct_amount_refunded = () =>
            _stripeRefund.Amount.ShouldEqual(10);
	}
}