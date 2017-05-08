using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_token
    {
        protected static StripeTokenCreateOptions StripeTokenCreateOptions;
        protected static StripeToken StripeToken;

        private static StripeTokenService _stripeTokenService;
        private static string _createdStripeTokenId;

        Establish context = () =>
        {
            _stripeTokenService = new StripeTokenService();
            StripeTokenCreateOptions = test_data.stripe_token_create_options.Valid();

            var stripeToken = _stripeTokenService.Create(StripeTokenCreateOptions);
            _createdStripeTokenId = stripeToken.Id;
        };

        Because of = () =>
            StripeToken = _stripeTokenService.Get(_createdStripeTokenId);

#pragma warning disable 169, 414
        Behaves_like<token_behaviors> behaviors;
#pragma warning restore 169, 414

    }
}