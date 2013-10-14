using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_creating_a_recipient
	{
		protected static StripeRecipientCreateOptions StripeRecipientCreateOptions;
		protected static StripeRecipient StripeRecipient;
		protected static BankAccountOptions BankAccountOptions;
		protected static StripeRecipientAccount StripeRecipientAccount;

		private static StripeRecipientService _stripeRecipientService;

		Establish context = () =>
		{
			var _stripeRecipientService = new StripeRecipientService();
			StripeRecipientCreateOptions = test_data.stripe_recipient_create_options.ValidIndividual();
		};

		Because of = () =>
		{
			StripeRecipient = _stripeRecipientService.Create(StripeRecipientCreateOptions);

			BankAccountOptions = StripeRecipient.BankAccountOptions;
		};

		Behaves_like<recipient_behaviors> behaviors;
	}
}