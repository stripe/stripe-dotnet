using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace Stripe.Tests.tokens
{
    public class when_used_with_api_key
    {
        protected static StripeTokenCreateOptions StripeTokenCreateOptions;
        protected static StripeToken StripeToken;

        private static StripeTokenService _stripeTokenService;

        Establish context = () =>
        {
            _stripeTokenService = new StripeTokenService("[your api key here]");
            StripeTokenCreateOptions = test_data.stripe_token_create_options.Valid();
        };

        Because of = () =>
            StripeToken = _stripeTokenService.Create(StripeTokenCreateOptions);

        Behaves_like<token_behaviors> behaviors;
    }
}
