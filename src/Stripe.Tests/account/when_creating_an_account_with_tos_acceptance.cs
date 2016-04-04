using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_an_account_with_tos_acceptance
    {
        private static StripeAccount _stripeAccount;
        private static StripeAccountService _stripeAccountService;
        private static StripeAccountCreateOptions _stripeAccountCreateOptions;
        private static DateTime? _timestamp;

        Establish context = () =>
        {
            _stripeAccountService = new StripeAccountService();
            _timestamp = DateTime.UtcNow.Date;

            _stripeAccountCreateOptions = new StripeAccountCreateOptions()
            {
                Email = "joe@" + Guid.NewGuid() + ".com",
                Managed = true,
                TosAcceptanceDate = _timestamp,
                TosAcceptanceIp = "8.8.8.8",
                TosAcceptanceUserAgent = "user-agent-7"
            };
        };

        Because of = () =>
            _stripeAccount = _stripeAccountService.Create(_stripeAccountCreateOptions);

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
