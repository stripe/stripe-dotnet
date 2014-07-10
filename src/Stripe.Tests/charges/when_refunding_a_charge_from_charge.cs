using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_refunding_a_charge_from_charge
	{
        private static StripeRefundCreateOptions StripeRefundCreateOptions;
		protected static StripeCharge StripeCharge;
        protected static StripeRefund StripeRefund;

		private static StripeChargeService _stripeChargeService;
        protected static StripeChargeCreateOptions _stripeChargeCreateOptions;

		Establish context = () =>
		{
			_stripeChargeService = new StripeChargeService();
			_stripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCard();
            StripeRefundCreateOptions = test_data.stripe_refund_create_options.FullRefundWithoutApplicationFee();

            StripeCharge = _stripeChargeService.Create(_stripeChargeCreateOptions);
		};

		Because of = () =>
		{
            StripeCharge.Refund(StripeRefundCreateOptions);
		};

        Behaves_like<refund_behaviors> behaviors;
	}
}