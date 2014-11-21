using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_updating_a_recipient
    {
        private static StripeRecipient _stripeRecipient;
        private static StripeRecipientService _stripeRecipientService;
        private static string _createdStripeRecipientId;
        private static StripeRecipientUpdateOptions _stripeRecipientUpdateOptions;

        Establish context = () =>
        {
            _stripeRecipientService = new StripeRecipientService();

            var stripeRecipient = _stripeRecipientService.Create(test_data.stripe_recipient_create_options.ValidIndividual());
            _createdStripeRecipientId = stripeRecipient.Id;

            _stripeRecipientUpdateOptions = test_data.stripe_recipient_update_options.Valid();
        };

        Because of = () =>
            _stripeRecipient = _stripeRecipientService.Update(_createdStripeRecipientId, _stripeRecipientUpdateOptions);

        It should_have_the_correct_name = () =>
            _stripeRecipient.Name.ShouldEqual(_stripeRecipientUpdateOptions.Name);

        It should_have_the_correct_email = () =>
            _stripeRecipient.Email.ShouldEqual(_stripeRecipientUpdateOptions.Email);

        It should_have_the_correct_description = () =>
            _stripeRecipient.Description.ShouldEqual(_stripeRecipientUpdateOptions.Description);

        It should_have_metadata = () =>
            _stripeRecipient.Metadata.Count.ShouldBeGreaterThan(0);

        It should_have_correct_metadata = () =>
            _stripeRecipient.Metadata.ShouldContainOnly(_stripeRecipientUpdateOptions.Metadata);
    }
}
