using Machine.Specifications;

namespace Stripe.Tests
{
    [Subject(typeof(StripeCharge))]
    public class when_creating_a_charge_with_an_api_key_and_new_id_fields
	{
		protected static StripeChargeCreateOptions StripeChargeCreateOptions;
		protected static StripeCharge StripeCharge;
		protected static StripeCard StripeCard;

		private static StripeChargeService _stripeChargeService;

		Establish context = () =>
		{
			_stripeChargeService = new StripeChargeService();
			StripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCardFromPCICompliantService();
		};

        Because of = () =>
        {
            StripeCharge = _stripeChargeService.Create(StripeChargeCreateOptions).Await();
            StripeCard = StripeCharge.StripeCard;
        };

        Behaves_like<charge_behaviors> behaviors;
	}
}