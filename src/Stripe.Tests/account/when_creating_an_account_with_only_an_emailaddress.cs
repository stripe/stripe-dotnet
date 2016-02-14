using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_an_account_with_only_an_emailaddress
    {
        private static StripeAccount _stripeAccount;
        private static StripeAccountService _stripeAccountService;
        private static StripeAccountCreateOptions _stripeAccountCreateOptions;

        Establish context = () =>
        {
            _stripeAccountService = new StripeAccountService();
            _stripeAccountCreateOptions = new StripeAccountCreateOptions()
            {
                Email = "joe@" + Guid.NewGuid() + ".com"
            };
        };

        Because of = () =>
            _stripeAccount = _stripeAccountService.Create(_stripeAccountCreateOptions);

        It should_have_the_correct_email_address = () =>
            _stripeAccount.Email.ShouldEqual(_stripeAccountCreateOptions.Email);
    }
}
