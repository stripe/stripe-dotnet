using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_deleting_a_recipient
	{
		private static StripeRecipientService _stripeRecipientService;
		private static string _createdStripeRecipientId;

		private Establish context = () =>
		{
			_stripeRecipientService = new StripeRecipientService();

			var stripeRecipient = _stripeRecipientService.Create(test_data.stripe_recipient_create_options.ValidIndividual());
			_createdStripeRecipientId = stripeRecipient.Id;
		};

		private Because of = () =>
			_stripeRecipientService.Delete(_createdStripeRecipientId);

		private It should_show_as_deleted = () =>
			_stripeRecipientService.Get(_createdStripeRecipientId).Deleted.ShouldEqual(true);
	}
}