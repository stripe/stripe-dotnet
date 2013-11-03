using Machine.Specifications;

namespace Stripe.Tests
{
	[Ignore("This should work fine, but I don't know how to create a pending transfer. :D")]
	public class when_canceling_a_transfer
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

		It should_show_as_canceled = () =>
			_stripeTransferService.Get(_createdStripeTransferId).Status.ShouldEqual("canceled");
	}
}
