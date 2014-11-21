using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_recipient
    {
        protected static StripeRecipientCreateOptions StripeRecipientCreateOptions;
        protected static StripeRecipient StripeRecipient;

        private static StripeRecipientService _stripeRecipientService;
        private static string _createdStripeRecipientId;

        Establish context = () =>
        {
            _stripeRecipientService = new StripeRecipientService();
            StripeRecipientCreateOptions = test_data.stripe_recipient_create_options.ValidCorporation();

            var stripeRecipient = _stripeRecipientService.Create(StripeRecipientCreateOptions);
            _createdStripeRecipientId = stripeRecipient.Id;
        };

        Because of = () =>
        {
            StripeRecipient = _stripeRecipientService.Get(_createdStripeRecipientId);
        };

        Behaves_like<recipient_behaviors> behaviors;
    }
}