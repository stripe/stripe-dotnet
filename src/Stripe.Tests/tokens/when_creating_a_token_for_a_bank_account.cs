using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_token_for_a_bank_account
    {
        private static StripeTokenCreateOptions _stripeTokenCreateOptions;
        private static StripeTokenService _stripeTokenService;
        private static StripeToken _stripeToken;

        Establish context = () =>
        {
            _stripeTokenService = new StripeTokenService();
            _stripeTokenCreateOptions = new StripeTokenCreateOptions()
            {
                BankAccount = test_data.bank_account_create_options.ValidBankAccountOptions()
            };
        };

        Because of = () =>
            _stripeToken = _stripeTokenService.Create(_stripeTokenCreateOptions);

        It should_have_a_bank_account_token_value = () =>
            _stripeToken.Id.ShouldStartWith("btok_");
    }
}