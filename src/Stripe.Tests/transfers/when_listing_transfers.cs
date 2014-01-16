using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_listing_transfers
	{
		private static IEnumerable<StripeTransfer> _stripeTransferList;
		private static StripeTransferService _stripeTransferService;

		Establish context = () =>
		{
			_stripeTransferService = new StripeTransferService();

            _stripeTransferService.Create(test_data.stripe_transfer_create_options.Valid()).Await();
            _stripeTransferService.Create(test_data.stripe_transfer_create_options.Valid()).Await();
            _stripeTransferService.Create(test_data.stripe_transfer_create_options.Valid()).Await();
		};

		Because of = () =>
            _stripeTransferList = _stripeTransferService.List().Result;

		It should_have_at_least_one_entry = () =>
			_stripeTransferList.Count().ShouldBeGreaterThanOrEqualTo(3);
	}
}
