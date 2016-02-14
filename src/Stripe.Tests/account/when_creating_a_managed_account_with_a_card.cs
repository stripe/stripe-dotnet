using System;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_managed_account_with_a_card
    {
        protected static StripeAccountCreateOptions CreateOrUpdateOptions;
        protected static StripeAccount StripeAccount;

        private static StripeAccountService _stripeAccountService;

        Establish context = () =>
        {
            _stripeAccountService = new StripeAccountService();
            CreateOrUpdateOptions = test_data.stripe_account_create_options.ValidAccountWithCard();
            CreateOrUpdateOptions.Country = "US";
            CreateOrUpdateOptions.Email = "joe" + Guid.NewGuid() + "@blahblah.com";
            CreateOrUpdateOptions.Managed = true;
        };

        Because of = () =>
            StripeAccount = _stripeAccountService.Create(CreateOrUpdateOptions);

        It should_have_the_correct_country = () =>
            StripeAccount.Country.ShouldEqual(CreateOrUpdateOptions.Country);

        It should_have_the_correct_email = () =>
            StripeAccount.Email.ShouldEqual(CreateOrUpdateOptions.Email);

        It should_be_a_managed_account = () =>
            StripeAccount.Managed.ShouldEqual(true);

        It should_have_the_correct_external_account_info = () =>
        {
            StripeAccount.ExternalAccounts.TotalCount.ShouldEqual(1);

            var firstEntry = (StripeCard)StripeAccount.ExternalAccounts.Data.First();

            firstEntry.AddressCountry.ShouldEqual(CreateOrUpdateOptions.ExternalCardAccount.AddressCountry);
            firstEntry.AddressLine1.ShouldEqual(CreateOrUpdateOptions.ExternalCardAccount.AddressLine1);
            firstEntry.AddressLine2.ShouldEqual(CreateOrUpdateOptions.ExternalCardAccount.AddressLine2);
            firstEntry.AddressCity.ShouldEqual(CreateOrUpdateOptions.ExternalCardAccount.AddressCity);
            firstEntry.AddressState.ShouldEqual(CreateOrUpdateOptions.ExternalCardAccount.AddressState);
            firstEntry.AddressZip.ShouldEqual(CreateOrUpdateOptions.ExternalCardAccount.AddressZip);
            firstEntry.ExpirationMonth.ShouldEqual(CreateOrUpdateOptions.ExternalCardAccount.ExpirationMonth);
            firstEntry.ExpirationYear.ShouldEqual(CreateOrUpdateOptions.ExternalCardAccount.ExpirationYear);
            firstEntry.Name.ShouldEqual(CreateOrUpdateOptions.ExternalCardAccount.Name);
            firstEntry.Currency.ShouldEqual(CreateOrUpdateOptions.ExternalCardAccount.Currency);
            firstEntry.DefaultForCurrency.ShouldEqual(CreateOrUpdateOptions.ExternalCardAccount.DefaultForCurrency.Value);
        };

        It should_have_the_correct_card = () =>
        {
            var firstEntry = (StripeCard)StripeAccount.ExternalAccounts.Data.First();

            StripeAccount.ExternalCards.First().Name.ShouldEqual(firstEntry.Name);
        };

        Behaves_like<account_behaviors> behaviors;
    }
}
