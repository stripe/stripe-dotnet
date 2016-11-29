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
        private static StripeToken _token;
        private static StripeAccountUpdateOptions _updateOptions;

        Establish context = () =>
        {
            // create a managed account
            _stripeAccountService = new StripeAccountService();
            var stripeAccountCreateOptions = test_data.stripe_account_create_options.ValidAccountWithCard();

            stripeAccountCreateOptions.Country = "US";
            stripeAccountCreateOptions.Email = "joe" + Guid.NewGuid() + "@blahblah.com";
            stripeAccountCreateOptions.Managed = true;

            _initialAccount = _stripeAccountService.Create(stripeAccountCreateOptions);

            // create a token for a new card
            var tokenOptions = test_data.stripe_token_create_options.ValidDebitCard();
            _token = new StripeTokenService().Create(tokenOptions);

            // set up the update for that account with the token
            _updateOptions = new StripeAccountUpdateOptions()
            {
                ExternalCardAccount = new StripeAccountCardOptions()
                {
                    TokenId = _token.Id
                }
            };
        };

        Because of = () =>
            _retrievedAccount = _stripeAccountService.Update(_initialAccount.Id, _updateOptions);

        It should_have_a_card_account = () =>
            _retrievedAccount.ExternalCards.ShouldNotBeNull();

        It should_have_the_right_card_account = () =>
            _retrievedAccount.ExternalCards.Where(card => card.Name == "Bob Winghead").ShouldNotBeNull();
    }
}
