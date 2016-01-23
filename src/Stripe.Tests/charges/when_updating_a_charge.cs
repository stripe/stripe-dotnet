using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_updating_a_charge
    {
        private static StripeChargeUpdateOptions _stripeChargeUpdateOptions;
        private static StripeCharge _stripeCharge;
        private static StripeChargeService _stripeChargeService;
        private static string _createdStripeChargeId;

        Establish context = () =>
        {
            _stripeChargeService = new StripeChargeService();

            var stripeCharge = _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _createdStripeChargeId = stripeCharge.Id;

            _stripeChargeUpdateOptions = test_data.stripe_charge_update_options.Valid();
        };

        Because of = () =>
            _stripeCharge = _stripeChargeService.Update(_createdStripeChargeId, _stripeChargeUpdateOptions);

        It should_have_the_correct_description = () =>
            _stripeCharge.Description.ShouldEqual(_stripeChargeUpdateOptions.Description);

        It should_have_metadata = () =>
            _stripeCharge.Metadata.Count.ShouldBeGreaterThan(0);

        It should_have_the_correct_metadata = () =>
            _stripeCharge.Metadata.ShouldContainOnly(_stripeChargeUpdateOptions.Metadata);

        It should_have_the_correct_receipt_email = () =>
            _stripeCharge.ReceiptEmail.ShouldEqual(_stripeChargeUpdateOptions.ReceiptEmail);
    }
}