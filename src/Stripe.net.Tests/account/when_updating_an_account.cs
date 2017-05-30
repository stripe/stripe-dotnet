using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_updating_an_account
    {
        protected static StripeAccountUpdateOptions CreateOrUpdateOptions;
        protected static StripeAccount StripeAccount;

        private static StripeAccountService _stripeAccountService;
        private static StripeAccountCreateOptions _stripeAccountCreateOptions;
        private static StripeAccountBankAccountOptions _stripeBankAccountOptions;

        Establish context = () =>
        {
            _stripeAccountService = new StripeAccountService();
            _stripeAccountCreateOptions = test_data.stripe_account_create_options.ValidAccountWithCard();
            _stripeAccountCreateOptions.Country = "US";
            _stripeAccountCreateOptions.Email = "joe" + Guid.NewGuid() + "@blahblah.com";
            _stripeAccountCreateOptions.Type = StripeAccountType.Custom;

            _stripeBankAccountOptions = test_data.stripe_account_create_options.ValidAccountWithBankAccount().ExternalBankAccount;

            StripeAccount = _stripeAccountService.Create(_stripeAccountCreateOptions);

            CreateOrUpdateOptions = new StripeAccountUpdateOptions()
            {
                BusinessName = Guid.NewGuid().ToString(),
                DebitNegativeBalances = !_stripeAccountCreateOptions.DebitNegativeBalances.Value,
                DeclineChargeOnAvsFailure = !_stripeAccountCreateOptions.DeclineChargeOnAvsFailure.Value,
                DeclineChargeOnCvcFailure = !_stripeAccountCreateOptions.DeclineChargeOnCvcFailure.Value,
                ExternalBankAccount = _stripeBankAccountOptions
            };

            // not changing these, setting for behaviors
            CreateOrUpdateOptions.BusinessUrl = _stripeAccountCreateOptions.BusinessUrl;
            CreateOrUpdateOptions.BusinessPrimaryColor = _stripeAccountCreateOptions.BusinessPrimaryColor;
            CreateOrUpdateOptions.DefaultCurrency = _stripeAccountCreateOptions.DefaultCurrency;
        };

        Because of = () =>
            StripeAccount = _stripeAccountService.Update(StripeAccount.Id, CreateOrUpdateOptions);

        It should_have_the_correct_external_account_info = () =>
        {
            StripeAccount.ExternalAccounts.TotalCount.ShouldEqual(1);
            var account = (StripeBankAccount) StripeAccount.ExternalAccounts.Data[0].BankAccount;
            account.Object.ShouldEqual(CreateOrUpdateOptions.ExternalBankAccount.Object);
        };

#pragma warning disable 169, 414
        Behaves_like<account_behaviors> behaviors;
#pragma warning restore 169, 414

    }
}
