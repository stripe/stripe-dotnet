using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_charge_with_a_token
    {
        protected static StripeChargeCreateOptions StripeChargeCreateOptions;
        protected static StripeCharge StripeCharge;
        protected static StripeCard StripeCard;
 
        private static StripeToken _stripeToken;
        private static StripeChargeService _stripeChargeService;

        Establish context = () =>
        {
            var stripeTokenService = new StripeTokenService();
            _stripeToken = stripeTokenService.Create(test_data.stripe_token_create_options.Valid());
            
            _stripeChargeService = new StripeChargeService();
            StripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidToken(_stripeToken.Id);
        };

        Because of = () =>
        {
            StripeCharge = _stripeChargeService.Create(StripeChargeCreateOptions);
            StripeCard = _stripeToken.StripeCard;
        };

        Behaves_like<charge_behaviors> behaviors;
    }
}