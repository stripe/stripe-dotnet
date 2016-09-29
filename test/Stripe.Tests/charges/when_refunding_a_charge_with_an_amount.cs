using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_refunding_a_charge_with_an_amount
    {
        private static StripeChargeCreateOptions _stripeChargeCreateOptions;
        private static StripeCharge _stripeCharge;
        private static StripeChargeService _stripeChargeService;
        private static string _createdStripeChargeId;

        Establish context = () =>
        {
            _stripeChargeService = new StripeChargeService();
            _stripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCard();

            var stripeCharge = _stripeChargeService.Create(_stripeChargeCreateOptions);
            _createdStripeChargeId = stripeCharge.Id;
        };

        Because of = () =>
        {
            new StripeRefundService().Create(_createdStripeChargeId, new StripeRefundCreateOptions { Amount = 250 });
            _stripeCharge = _stripeChargeService.Get(_createdStripeChargeId);
        };

        It should_have_the_correct_amount_refunded = () =>
            _stripeCharge.AmountRefunded.ShouldEqual(250);
    }
}