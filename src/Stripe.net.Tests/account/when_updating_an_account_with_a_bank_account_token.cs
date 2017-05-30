using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_updating_an_account_with_a_bank_account_token
    {
        private static StripeAccountService _stripeAccountService;
        private static StripeAccount _initialAccount;
        private static StripeAccount _retrievedAccount;
        private static StripeToken _token;
        private static StripeAccountUpdateOptions _updateOptions;

        Establish context = () =>
        {
            _stripeAccountService = new StripeAccountService();
            var stripeAccountCreateOptions = test_data.stripe_account_create_options.ValidAccountWithBankAccount();
            stripeAccountCreateOptions.Country = "US";
            stripeAccountCreateOptions.Email = "joe" + Guid.NewGuid() + "@blahblah.com";
            stripeAccountCreateOptions.Type = StripeAccountType.Custom;

            _initialAccount = _stripeAccountService.Create(stripeAccountCreateOptions);

            var tokenService = new StripeTokenService();
            var tokenCreateOptions = new StripeTokenCreateOptions()
            {
                BankAccount = test_data.bank_account_create_options.ValidBankAccountOptions()
            };

            _token = tokenService.Create(tokenCreateOptions);

            _updateOptions = new StripeAccountUpdateOptions()
            {
                ExternalBankAccount = new StripeAccountBankAccountOptions
                {
                    TokenId = _token.Id
                }
            };
        };

        Because of = () =>
            _retrievedAccount = _stripeAccountService.Update(_initialAccount.Id, _updateOptions);

        It should_have_a_bank_account = () =>
            _retrievedAccount.ExternalAccounts.ShouldNotBeNull();
    }
}
