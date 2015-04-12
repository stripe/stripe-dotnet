using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_refunding_a_charge_with_refund_service
    {
        private static StripeRefund _stripeRefund;
        private static StripeRefundService _stripeRefundService;
        private static string _createdStripeChargeId;

        Establish context = () =>
        {
            _stripeRefundService = new StripeRefundService();

            var chargeService = new StripeChargeService();

            var stripeCharge = chargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _createdStripeChargeId = stripeCharge.Id;
        };

        Because of = () =>
            _stripeRefund = _stripeRefundService.Create(_createdStripeChargeId);

        It should_create_with_stripe_charge_id = () =>
            _stripeRefund.ChargeId.ShouldEqual(_createdStripeChargeId);

        It should_refund_full_amount = () =>
            _stripeRefund.Amount.ShouldEqual(test_data.stripe_charge_create_options.ValidCard().Amount.Value);
    }
}