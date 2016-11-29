using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_charge_with_a_card
    {
        protected static StripeChargeCreateOptions StripeChargeCreateOptions;
        protected static StripeCharge StripeCharge;
        protected static StripeCard StripeCard;

        private static StripeChargeService _stripeChargeService;

        Establish context = () =>
        {
            _stripeChargeService = new StripeChargeService();
            StripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCard();
        };

        Because of = () =>
        {
            StripeCharge = _stripeChargeService.Create(StripeChargeCreateOptions);
            StripeCard = StripeCharge.Source.Card;
        };

        Behaves_like<charge_behaviors> behaviors;

        It should_have_metadata = () =>
            StripeCharge.Metadata.ShouldNotBeNull();

        It should_have_the_correct_metadata = () =>
            StripeCharge.Metadata.ShouldContainOnly(StripeChargeCreateOptions.Metadata);
    }
}