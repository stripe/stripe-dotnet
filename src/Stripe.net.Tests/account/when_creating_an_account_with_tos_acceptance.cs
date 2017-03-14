using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_an_account_with_tos_acceptance
    {
        private static StripeAccount _stripeAccount;
        private static StripeAccountService _stripeAccountService;
        private static StripeAccountCreateOptions _stripeAccountCreateOptions;

        Establish context = () =>
        {
            _stripeAccount = Cache.GetManagedAccountWithCard();
            _stripeAccountCreateOptions = Cache.ManagedAccountWithCardOptions;
        };

        Because of = () =>
            _stripeAccount = Cache.GetManagedAccountWithCard();

        It should_have_the_correct_email_address = () =>
            _stripeAccount.Email.ShouldEqual(_stripeAccountCreateOptions.Email);

        It should_have_the_correct_tos_acceptance_values = () =>
        {
            _stripeAccount.TermsOfServiceAcceptance.Date.ShouldEqual(_stripeAccountCreateOptions.TosAcceptanceDate.GetValueOrDefault());
            _stripeAccount.TermsOfServiceAcceptance.Ip.ShouldEqual(_stripeAccountCreateOptions.TosAcceptanceIp);
            _stripeAccount.TermsOfServiceAcceptance.UserAgent.ShouldEqual(_stripeAccountCreateOptions.TosAcceptanceUserAgent);
        };
    }
}
