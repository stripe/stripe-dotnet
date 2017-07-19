using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_charge_with_a_token
    {
        protected static StripeChargeCreateOptions StripeChargeCreateOptions;
        protected static StripeCharge StripeCharge;
        protected static StripeCard StripeCard;
 
        private static StripeChargeService _stripeChargeService;

        Establish context = () =>
        {
            _stripeChargeService = new StripeChargeService();
            StripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidToken("tok_visa");
        };

        Because of = () =>
        {
            StripeCharge = _stripeChargeService.Create(StripeChargeCreateOptions);
        };

#pragma warning disable 169, 414
        Behaves_like<charge_behaviors> behaviors;
#pragma warning restore 169, 414

    }
}