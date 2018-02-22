using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_topup_with_a_token
    {
        protected static StripeTopupCreateOptions StripeTopupCreateOptions;
        protected static StripeTopup StripeTopup;
        protected static StripeCard StripeCard;
 
        private static StripeTopupService _stripeTopupService;

        Establish context = () =>
        {
            _stripeTopupService = new StripeTopupService();
            StripeTopupCreateOptions = test_data.stripe_topup_create_options.ValidToken("tok_visa");
        };

        Because of = () =>
        {
            StripeTopup = _stripeTopupService.Create(StripeTopupCreateOptions);
        };

#pragma warning disable 169, 414
        Behaves_like<topup_behaviors> behaviors;
#pragma warning restore 169, 414

    }
}
