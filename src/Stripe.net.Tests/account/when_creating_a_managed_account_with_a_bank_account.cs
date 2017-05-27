using System;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_custom_account_with_a_bank_account
    {
        protected static StripeAccountCreateOptions CreateOrUpdateOptions;
        protected static StripeAccount StripeAccount;

        private static StripeAccountService _stripeAccountService;

        private Establish context = () =>
        {
            _stripeAccountService = new StripeAccountService();

            Cache.GetCustomAccountWithBankAccount();
            CreateOrUpdateOptions = Cache.CustomAccountWithBankAccountOptions;
        };

        Because of = () =>
            StripeAccount = Cache.GetCustomAccountWithBankAccount();

        It should_have_the_correct_country = () =>
            StripeAccount.Country.ShouldEqual(CreateOrUpdateOptions.Country);

        It should_have_the_correct_email = () =>
            StripeAccount.Email.ShouldEqual(CreateOrUpdateOptions.Email);

        It should_be_a_custom_account = () =>
            StripeAccount.Type.ShouldEqual("custom");

        It should_have_the_correct_external_account_info = () =>
        {
            StripeAccount.ExternalAccounts.TotalCount.ShouldEqual(1);

            var firstEntry = (StripeBankAccount)StripeAccount.ExternalAccounts.Data.First().BankAccount;

            firstEntry.Object.ShouldEqual(firstEntry.Object);
            firstEntry.Currency.ShouldEqual(CreateOrUpdateOptions.ExternalBankAccount.Currency);
            firstEntry.Country.ShouldEqual(CreateOrUpdateOptions.ExternalBankAccount.Country);
            firstEntry.RoutingNumber.ShouldEqual(CreateOrUpdateOptions.ExternalBankAccount.RoutingNumber);
            firstEntry.AccountHolderName.ShouldEqual(CreateOrUpdateOptions.ExternalBankAccount.AccountHolderName);
            firstEntry.AccountHolderType.ShouldEqual(CreateOrUpdateOptions.ExternalBankAccount.AccountHolderType);
        };

        It should_have_the_correct_bank_account = () =>
        {
            var firstEntry = (StripeBankAccount) StripeAccount.ExternalAccounts.Data.First().BankAccount;

            StripeAccount.ExternalAccounts.Data.First().BankAccount.AccountHolderName.ShouldEqual(firstEntry.AccountHolderName);
        };

#pragma warning disable 169, 414
        Behaves_like<account_behaviors> behaviors;
#pragma warning restore 169, 414

    }
}
