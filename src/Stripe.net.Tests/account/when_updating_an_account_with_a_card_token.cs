using System;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_updating_an_account_with_a_card_token
    {
        private static StripeAccountService _stripeAccountService;
        private static StripeAccount _initialAccount;
        private static StripeAccount _retrievedAccount;
        private static StripeAccountUpdateOptions _updateOptions;

        Establish context = () =>
        {
            // create a custom account
            _stripeAccountService = new StripeAccountService();

            _initialAccount = Cache.GetCustomAccountWithCard();

            _updateOptions = new StripeAccountUpdateOptions()
            {
                ExternalCardAccount = new StripeAccountCardOptions()
                {
                    TokenId = "tok_visa_debit"
                }
            };
        };

        Because of = () =>
            _retrievedAccount = _stripeAccountService.Update(_initialAccount.Id, _updateOptions);

        It should_have_a_card_account = () =>
            _retrievedAccount.ExternalAccounts.ShouldNotBeNull();

        It should_have_the_right_card_account = () =>
            _retrievedAccount.ExternalAccounts.Data.Where(acc => acc.Card.Name == "Bob Winghead").ShouldNotBeNull();
    }
}
