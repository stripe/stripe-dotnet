using System;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_managed_account_with_a_bank_account
    {
        protected static StripeAccountCreateOptions CreateOrUpdateOptions;
        protected static StripeAccount StripeAccount;

        private static StripeAccountService _stripeAccountService;

        Establish context = () =>
        {
            _stripeAccountService = new StripeAccountService();
            CreateOrUpdateOptions = test_data.stripe_account_create_options.ValidAccountWithBankAccount();
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

            var firstEntry = (StripeBankAccount)StripeAccount.ExternalAccounts.Data.First();

            firstEntry.Object.ShouldEqual(firstEntry.Object);
            firstEntry.Currency.ShouldEqual(CreateOrUpdateOptions.ExternalBankAccount.Currency);
            firstEntry.Country.ShouldEqual(CreateOrUpdateOptions.ExternalBankAccount.Country);
            firstEntry.RoutingNumber.ShouldEqual(CreateOrUpdateOptions.ExternalBankAccount.RoutingNumber);
            firstEntry.AccountHolderName.ShouldEqual(CreateOrUpdateOptions.ExternalBankAccount.AccountHolderName);
            firstEntry.AccountHolderType.ShouldEqual(CreateOrUpdateOptions.ExternalBankAccount.AccountHolderType);
        };

        It should_have_the_correct_bank_account = () =>
        {
            var firstEntry = (StripeBankAccount) StripeAccount.ExternalAccounts.Data.First();

            StripeAccount.ExternalBankAccounts.First().Name.ShouldEqual(firstEntry.Name);
        };

        Behaves_like<account_behaviors> behaviors;
    }
}
