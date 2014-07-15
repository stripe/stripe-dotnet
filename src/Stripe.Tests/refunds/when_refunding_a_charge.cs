using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_refunding_a_charge
	{
        private static StripeRefundCreateOptions StripeRefundCreateOptions;
        private static StripeCharge StripeCharge;
        private static StripeRefund StripeRefund;

		private static StripeChargeCreateOptions _stripeChargeCreateOptions;
		private static StripeChargeService _stripeChargeService;
        private static StripeRefundService _stripeRefundService;

		Establish context = () =>
		{
			_stripeChargeService = new StripeChargeService();
            _stripeRefundService = new StripeRefundService();
			_stripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCard();
            StripeRefundCreateOptions = test_data.stripe_refund_create_options.FullRefundWithoutApplicationFee();

			StripeCharge = _stripeChargeService.Create(_stripeChargeCreateOptions);
            
		};

        Because of = () =>
            StripeRefund = _stripeRefundService.Create(StripeCharge.Id, StripeRefundCreateOptions);

        Behaves_like<refund_behaviors> behaviors;
	}
}