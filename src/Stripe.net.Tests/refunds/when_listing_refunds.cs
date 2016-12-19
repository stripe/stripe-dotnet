using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_refunds
    {
        private static IEnumerable<StripeRefund> _stripeRefundList;
        private static StripeRefundService _stripeRefundService;
        private static string _createdStripeChargeId;
        private static List<string> _refundIds = new List<string>();

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

            _refundIds.Add(refund.Id);

            refund = _stripeRefundService.Create(_createdStripeChargeId, new StripeRefundCreateOptions()
            {
                Amount = 400,
                Reason = StripeRefundReasons.RequestedByCustomer,
                Metadata = new Dictionary<string, string>() { { "key", "value" } }
            });

            _refundIds.Add(refund.Id);
        };

        Because of = () =>
            _stripeRefundList = _stripeRefundService.List(new StripeRefundListOptions { ChargeId = _createdStripeChargeId } );

        It should_contain_ids = () =>
            _stripeRefundList.Select(r => r.Id).ShouldContainOnly(_refundIds);
    }
}