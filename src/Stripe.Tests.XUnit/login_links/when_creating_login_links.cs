// This test is commented out as it require a real Express account on your platform
// before you can create a login link for this account. Every developer would have
// to change this code to have the test suite pass on their account.
//
//using System;
//using FluentAssertions;
//using Xunit;
//
//namespace Stripe.Tests.Xunit
//{
//    public class creating_login_links
//    {
//        StripeLoginLink LoginLink;
//
//        public creating_login_links()
//        {
//            var options = new StripeLoginLinkCreateOptions {
//                RedirectUrl = "https://example.com",
//            };
//            // This is the id of an Express account for the account associated with the test suite.
//            // When testing locally you need to put an id valid for your platform.
//            LoginLink = new StripeLoginLinkService(Cache.ApiKey).Create("acct_1ATVm2ETkVWzzLxp", options);
//        }
//
//        [Fact]
//        public void login_link_has_url()
//        {
//            LoginLink.Url.Should().NotBeNull();
//            LoginLink.Url.Should().Contain("http");
//        }
//    }
//}
