using System;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_login_link
    {
        protected static StripeLoginLink StripeLoginLink;

        private static StripeLoginLinkService _stripeLoginLinkService;

        Establish context = () =>
        {
            _stripeLoginLinkService = new StripeLoginLinkService();
        };

        Because of = () =>
        {
            StripeLoginLink = _stripeLoginLinkService.Create("acct_1ATUvjL0EMaiKBY7");
        };

        It should_have_a_url = () =>
            StripeLoginLink.Url.ShouldContain("http");
    }
}
