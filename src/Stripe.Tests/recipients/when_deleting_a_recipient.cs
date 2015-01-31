using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_deleting_a_recipient
    {
        private static StripeRecipientService _stripeRecipientService;
        private static string _createdStripeRecipientId;

        Establish context = () =>
        {
            _stripeRecipientService = new StripeRecipientService();

            var stripeRecipient = _stripeRecipientService.Create(test_data.stripe_recipient_create_options.ValidIndividual());
            _createdStripeRecipientId = stripeRecipient.Id;
        };

        Because of = () =>
            _stripeRecipientService.Delete(_createdStripeRecipientId);
    }
}