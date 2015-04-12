using System.Collections.Generic;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_updating_a_refund
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
                Reason = StripeRefundReasons.RequestedByCustomer,
                Metadata = new Dictionary<string, string>() { { "key", "value" } }
            });

            _createdStripeRefundId = refund.Id;
        };

        Because of = () =>
            _stripeRefund = _stripeRefundService.Update(_createdStripeChargeId, _createdStripeRefundId, new StripeRefundUpdateOptions()
            {
                Metadata = new Dictionary<string, string>() {{ "key", "eulav"}}
            });

        It should_have_metadata = () =>
            _stripeRefund.Metadata["key"].ShouldEqual("eulav");
    }
}