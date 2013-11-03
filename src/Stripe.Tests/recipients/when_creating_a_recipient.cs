using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_creating_a_recipient
	{
		protected static StripeRecipientCreateOptions StripeRecipientCreateOptions;
		protected static StripeRecipient StripeRecipient;

		private static StripeRecipientService _stripeRecipientService;

		Establish context = () =>
		{
			_stripeRecipientService = new StripeRecipientService();
			StripeRecipientCreateOptions = test_data.stripe_recipient_create_options.ValidIndividual();
		};

		Because of = () =>
			StripeRecipient = _stripeRecipientService.Create(StripeRecipientCreateOptions);

		Behaves_like<recipient_behaviors> behaviors;
	}
}