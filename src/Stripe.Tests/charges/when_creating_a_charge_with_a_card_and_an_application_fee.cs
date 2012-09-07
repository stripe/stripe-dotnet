using Machine.Specifications;

namespace Stripe.Tests
{
	[Ignore("this test should work, but you have to setup an application in stripe and all that and welllll... i'm lazy!")]
	public class when_creating_a_charge_with_a_card_and_an_application_fee
	{
		protected static StripeChargeCreateOptions StripeChargeCreateOptions;
		protected static StripeCharge StripeCharge;
		protected static StripeCard StripeCard;

		private static StripeChargeService _stripeChargeService;

		Establish context = () =>
		{
			_stripeChargeService = new StripeChargeService();
			StripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCard();
			StripeChargeCreateOptions.ApplicationFeeInCents = 25;
		};

		Because of = () =>
		{
			StripeCharge = _stripeChargeService.Create(StripeChargeCreateOptions);
			StripeCard = StripeCharge.StripeCard;
		};

		It should_have_two_fee_details = () =>
			StripeCharge.FeeDetails.Count.ShouldBeGreaterThanOrEqualTo(2);
	}
}