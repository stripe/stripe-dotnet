using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_retrieving_an_account
    {
        private static StripeAccount _createdAccount;
        private static StripeAccount _retrievedAccount;
        private static StripeAccountService _stripeAccountService;

        Establish context = () =>
        {
            _stripeAccountService = new StripeAccountService();

            _createdAccount = Cache.GetCustomAccountWithCard();
        };

        Because of = () =>
            _retrievedAccount = _stripeAccountService.Get(_createdAccount.Id);

        It should_have_the_same_id = () =>
            _createdAccount.Id.ShouldEqual(_retrievedAccount.Id);

        It should_have_the_correct_email_address = () =>
            _createdAccount.Email.ShouldEqual(_retrievedAccount.Email);
    }
}
