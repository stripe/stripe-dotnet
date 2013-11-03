using Machine.Specifications;

namespace Stripe.Tests
{
	[Behaviors]
	public class transfer_behaviors
	{
		protected static StripeTransferCreateOptions StripeTransferCreateOptions;
		protected static StripeTransfer StripeTransfer;
		protected static BankAccountOptions BankAccountOptions;

		private It should_have_a_new_id = () =>
			StripeTransfer.Id.ShouldNotBeNull();

		private It should_have_the_correct_amount = () =>
			StripeTransfer.AmountInCents.ShouldEqual(StripeTransferCreateOptions.AmountInCents);

		private It should_have_the_correct_currency = () =>
			StripeTransfer.Currency.ShouldEqual(StripeTransferCreateOptions.Currency);
	}
}
