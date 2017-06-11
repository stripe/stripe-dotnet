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
            // This is the id of an Express account for this library's platform.
            // When testing locally you need to put an id valid for your platform.
            StripeLoginLink = _stripeLoginLinkService.Create("acct_1ATVm2ETkVWzzLxp");
        };

        It should_have_a_url = () =>
            StripeLoginLink.Url.ShouldContain("http");
    }
}
