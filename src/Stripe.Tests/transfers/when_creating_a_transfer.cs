using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_creating_a_transfer
	{
		protected static StripeTransferCreateOptions StripeTransferCreateOptions;
		protected static StripeTransfer StripeTransfer;

		private static StripeTransferService _stripeTransferService;

		private Establish context = () =>
		{
			var _stripeTransferService = new StripeTransferService();
			StripeTransferCreateOptions = test_data.stripe_transfer_create_options.Valid();
		};

		private Because of = () =>
		{
			StripeTransfer = _stripeTransferService.Create(StripeTransferCreateOptions);
		};

		private Behaves_like<transfer_behaviors> behaviors;
	}
}