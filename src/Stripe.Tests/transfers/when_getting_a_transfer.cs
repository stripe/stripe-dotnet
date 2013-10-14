using Machine.Specifications;

namespace Stripe.Tests.transfers
{
	public class when_getting_a_transfer
	{
		protected static StripeTransferCreateOptions StripeTransferCreateOptions;
		protected static StripeTransfer StripeTransfer;

		private static StripeTransferService _stripeTransferService;
		private static string _createStripeTransferId;

		private Establish context = () =>
		{
			_stripeTransferService = new StripeTransferService();
			StripeTransferCreateOptions = test_data.stripe_transfer_create_options.Valid();

			var stripeTransfer = _stripeTransferService.Create(StripeTransferCreateOptions);
			_createStripeTransferId = stripeTransfer.Id;
		};

		private Because of = () =>
		{
			StripeTransfer = _stripeTransferService.Get(_createStripeTransferId);
		};

		private Behaves_like<transfer_behaviors> behaviors;
	}
}