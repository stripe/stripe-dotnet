using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_token
    {
        protected static StripeTokenCreateOptions StripeTokenCreateOptions;
        protected static StripeToken StripeToken;

        private static StripeTokenService _stripeTokenService;

        Establish context = () =>
        {
            _stripeTokenService = new StripeTokenService();
            StripeTokenCreateOptions = test_data.stripe_token_create_options.Valid();
        };

        Because of = () =>
            StripeToken = _stripeTokenService.Create(StripeTokenCreateOptions);

        Behaves_like<token_behaviors> behaviors;
    }
}