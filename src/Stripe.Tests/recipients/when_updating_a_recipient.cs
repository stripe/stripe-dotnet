using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_updating_a_recipient
	{
		private static StripeRecipient _stripeRecipient;
		private static StripeRecipientService _stripeRecipientService;
		private static string _createdStripeRecipientId;
		private static StripeRecipientUpdateOptions _stripeRecipientUpdateOptions;

		private Establish context = () =>
		{
			_stripeRecipientService = new StripeRecipientService();

			var stripeRecipient = _stripeRecipientService.Create(test_data.stripe_recipient_create_options.ValidCorporation());
			_createdStripeRecipientId = stripeRecipient.Id;

			_stripeRecipientUpdateOptions = test_data.stripe_recipient_update_options.ValidCorporation();
		};

		private Because of = () =>
			_stripeRecipient = _stripeRecipientService.Update(_createdStripeRecipientId, _stripeRecipientUpdateOptions);

		private It should_have_the_correct_description = () =>
			_stripeRecipient.Description.ShouldEqual(_stripeRecipientUpdateOptions.Description);
	}
}
