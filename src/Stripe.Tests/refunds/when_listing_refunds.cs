using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_listing_refunds
	{
		private static List<StripeRefund> _stripeRefundList;
        private static StripeRefundService _stripeRefundService;
		private static StripeChargeService _stripeChargeService;
        private static string _stripeChargeId;

		Establish context = () =>
		{
            _stripeRefundService = new StripeRefundService();
			_stripeChargeService = new StripeChargeService();

            _stripeChargeId = _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard()).Id;
            _stripeRefundService.Create(_stripeChargeId, test_data.stripe_refund_create_options.PartialRefundWithoutApplicationFee());
            _stripeRefundService.Create(_stripeChargeId, test_data.stripe_refund_create_options.PartialRefundWithoutApplicationFee());
            _stripeRefundService.Create(_stripeChargeId, test_data.stripe_refund_create_options.PartialRefundWithoutApplicationFee());
            _stripeRefundService.Create(_stripeChargeId, test_data.stripe_refund_create_options.PartialRefundWithoutApplicationFee());
		};

		Because of = () =>
            _stripeRefundList = _stripeRefundService.List(_stripeChargeId).ToList();

		It should_have_atleast_4_entries = () =>
            _stripeRefundList.Count.ShouldBeGreaterThanOrEqualTo(4);
	}
}