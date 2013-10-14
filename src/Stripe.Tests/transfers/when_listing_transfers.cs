using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests.transfers
{
	public class when_listing_transfers
	{
		private static List<StripeTransfer> _stripeTransferList;
		private static StripeTransferService _stripeTransferService;

		private Establish context = () =>
		{
			_stripeTransferService = new StripeTransferService();

			_stripeTransferService.Create(test_data.stripe_transfer_create_options.Valid());
		};

		private Because of = () =>
			_stripeTransferList = _stripeTransferService.List().ToList();

		private It should_have_at_least_one_entry = () =>
			_stripeTransferList.Count.ShouldBeGreaterThanOrEqualTo(1);
	}
}
