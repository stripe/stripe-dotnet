using System.Collections.Generic;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_refund
    {
        private static StripeRefund _stripeRefund;
        private static StripeRefundService _stripeRefundService;
        private static string _createdStripeChargeId;
        private static string _createdStripeRefundId;

        Establish context = () =>
        {
            _stripeRefundService = new StripeRefundService();

            var chargeService = new StripeChargeService();

            var stripeCharge = chargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _createdStripeChargeId = stripeCharge.Id;

            var refund = _stripeRefundService.Create(_createdStripeChargeId, new StripeRefundCreateOptions()
            {
                Amount = 300,
                Reason = StripeRefundReasons.Fradulent,
                Metadata = new Dictionary<string, string>() { { "key", "value" } }
            });

            _createdStripeRefundId = refund.Id;
        };

        Because of = () =>
            _stripeRefund = _stripeRefundService.Get(_createdStripeChargeId, _createdStripeRefundId);

        It should_create_with_stripe_charge_id = () =>
            _stripeRefund.ChargeId.ShouldEqual(_createdStripeChargeId);

        It should_refund_300 = () =>
            _stripeRefund.Amount.ShouldEqual(300);

        It should_have_reason = () =>
            _stripeRefund.Reason.ShouldEqual(StripeRefundReasons.Fradulent);

        It should_have_metadata = () =>
            _stripeRefund.Metadata["key"].ShouldEqual("value");
    }
}