using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_getting_a_refund
	{
		protected static StripeRefundCreateOptions StripeRefundCreateOptions;
		protected static StripeCharge StripeCharge;
		protected static StripeRefund StripeRefund;


		private static StripeChargeService _stripeChargeService;
        private static StripeRefundService _stripeRefundService;
		private static string _createdStripeChargeId;
        private static string _createdStripeRefundId;

		Establish context = () =>
		{
			_stripeChargeService = new StripeChargeService();
            _stripeRefundService = new StripeRefundService();
			var _stripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCard();
            StripeRefundCreateOptions = test_data.stripe_refund_create_options.FullRefundWithoutApplicationFee();

            StripeCharge = _stripeChargeService.Create(_stripeChargeCreateOptions);
			_createdStripeChargeId = StripeCharge.Id;
            var stripeRefund = _stripeRefundService.Create(_createdStripeChargeId, StripeRefundCreateOptions);
            _createdStripeRefundId = StripeRefund.Id;
		};

		Because of = () =>
		{
            StripeRefund = _stripeRefundService.Get(_createdStripeChargeId, _createdStripeRefundId);
		};

		Behaves_like<refund_behaviors> behaviors;
	}
}