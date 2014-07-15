using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_over_refunding_a_charge
	{
		protected static StripeChargeCreateOptions StripeChargeCreateOptions;
		protected static StripeCharge StripeCharge;
		protected static StripeCard StripeCard;

		private static StripeChargeService _stripeChargeService;
        private static StripeRefundService _stripeRefundService;
        private static string _createdStripeChargeId;

		Establish context = () =>
		{
			_stripeChargeService = new StripeChargeService();
            _stripeRefundService = new StripeRefundService();
			StripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCard();
            _createdStripeChargeId = _stripeChargeService.Create(StripeChargeCreateOptions).Id;

            _stripeRefundService.Create(_createdStripeChargeId, test_data.stripe_refund_create_options.FullRefundWithoutApplicationFee());
		};

		It should_throw_exception = () =>
		{
            var exception = Catch.Exception(() => _stripeRefundService.Create(_createdStripeChargeId, test_data.stripe_refund_create_options.PartialRefundWithoutApplicationFee()));
			exception.Message.ShouldNotBeNull(); 
			
			// this is basically a useless test. I need to figure out how to make stripe send back a 'charge' value in the exception.
			// https://github.com/jaymedavis/stripe.net/issues/42
		};
	}
}