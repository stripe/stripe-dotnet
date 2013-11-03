using Machine.Specifications;

namespace Stripe.Tests.transfers
{
	public class when_cancelling_a_transfer
	{
		private static StripeTransferService _stripeTransferService;
		private static string _createdStripeTransferId;

		Establish context = () =>
		{
			_stripeTransferService = new StripeTransferService();

			var stripeTransfer = _stripeTransferService.Create(test_data.stripe_transfer_create_options.Valid());
			_createdStripeTransferId = stripeTransfer.Id;
		};

		Because of = () =>
			_stripeTransferService.Cancel(_createdStripeTransferId);

		It should_show_as_deleted = () =>
			_stripeTransferService.Get(_createdStripeTransferId).Deleted.ShouldEqual(true);
	}
}
