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
            var exception = (StripeException) Catch.Exception(() => _stripeChargeService.Create(StripeChargeCreateOptions));
            exception.Message.ShouldNotBeNull();
            exception.StripeError.ChargeId.ShouldNotBeNull();
        };
    }
}