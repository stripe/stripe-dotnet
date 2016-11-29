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

        It should_have_active_account = () =>
            StripeRecipient.ActiveAccount.ShouldNotBeNull();

        It should_have_active_account_routing_number = () =>
            StripeRecipient.ActiveAccount.RoutingNumber.ShouldEqual(StripeRecipientCreateOptions.BankAccount.RoutingNumber);

        It should_have_active_account_country = () =>
            StripeRecipient.ActiveAccount.Country.ShouldEqual(StripeRecipientCreateOptions.BankAccount.Country);

        It should_have_active_account_currency = () =>
            StripeRecipient.ActiveAccount.Currency.ShouldEqual("usd");

        It should_have_default_for_currency = () =>
            StripeRecipient.ActiveAccount.DefaultForCurrency.ShouldBeFalse();

        It should_have_active_account_last4 = () =>
            StripeRecipient.ActiveAccount.Last4.ShouldEqual("6789");

        It should_have_active_account_status = () =>
            StripeRecipient.ActiveAccount.Status.ShouldNotBeEmpty();

        It should_have_active_account_bank_name = () =>
            StripeRecipient.ActiveAccount.BankName.ShouldNotBeEmpty();

        It should_have_active_account_fingerprint = () =>
            StripeRecipient.ActiveAccount.Fingerprint.ShouldNotBeEmpty();
    }
}