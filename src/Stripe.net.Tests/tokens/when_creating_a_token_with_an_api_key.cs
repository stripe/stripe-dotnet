using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_token_with_an_api_key
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

#pragma warning disable 169, 414
        Behaves_like<token_behaviors> behaviors;
#pragma warning restore 169, 414

    }
}
