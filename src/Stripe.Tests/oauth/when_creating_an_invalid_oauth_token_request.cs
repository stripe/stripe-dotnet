using Machine.Specifications;
using System;

namespace Stripe.Tests
{
    public class when_creating_an_invalid_oauth_token_request
    {
        protected static StripeOAuthTokenCreateOptions StripeOAuthTokeCreateOptions;
        protected static StripeOAuthToken StripeOAuthToken;
        protected static Exception Exception;

        private static StripeOAuthTokenService _stripeOAuthTokenService;

        Establish context = () =>
        {
            _stripeOAuthTokenService = new StripeOAuthTokenService();
            StripeOAuthTokeCreateOptions = new StripeOAuthTokenCreateOptions() { Code = "1234", GrantType = "authorization_code" };
        };

        Because of = () =>
            Exception = Catch.Exception(() => _stripeOAuthTokenService.Create(StripeOAuthTokeCreateOptions));

        It should_have_an_invalid_code = () =>
            ((StripeException)Exception).StripeError.Error.ShouldEqual("invalid_grant");
    }
}
