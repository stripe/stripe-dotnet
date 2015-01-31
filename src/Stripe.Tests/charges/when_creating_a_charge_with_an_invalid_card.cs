using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_charge_with_an_invalid_card
    {
        protected static StripeChargeCreateOptions StripeChargeCreateOptions;
        protected static StripeCharge StripeCharge;
        protected static StripeCard StripeCard;

        private static StripeChargeService _stripeChargeService;

        Establish context = () =>
        {
            _stripeChargeService = new StripeChargeService();
            StripeChargeCreateOptions = test_data.stripe_charge_create_options.InvalidCard();
        };

        It should_throw_exception = () =>
        {
            var exception = Catch.Exception(() => _stripeChargeService.Create(StripeChargeCreateOptions));
            exception.Message.ShouldNotBeNull(); 
            
            // this is basically a useless test. I need to figure out how to make stripe send back a 'charge' value in the exception.
            // https://github.com/jaymedavis/stripe.net/issues/42
        };
    }
}