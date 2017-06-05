using System;
using System.Diagnostics;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_deleting_an_account
    {
        private static string _stripeAccountId;
        private static StripeAccountService _stripeAccountService;
        private static StripeAccountCreateOptions _stripeAccountCreateOptions;

        Establish context = () =>
        {
            _stripeAccountService = new StripeAccountService();
            _stripeAccountCreateOptions = new StripeAccountCreateOptions()
            {
                Email = "joe@" + Guid.NewGuid() + ".com",
                Type = StripeAccountType.Custom
            };
            _stripeAccountId = _stripeAccountService.Create(_stripeAccountCreateOptions).Id;
        };

        Because of = () =>
            _stripeAccountService.Delete(_stripeAccountId);

        It should_throw_exception_when_getting = () =>
        {
            var exception = Catch.Exception(() =>
                {
                    var result = _stripeAccountService.Get(_stripeAccountId);

                    Trace.WriteLine("request id: " + result.StripeResponse.RequestId);
                }
            );

            exception.Message.ShouldContain("or that account does not exist");
        };
    }
}
