using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_topup
    {
        protected static StripeTopupCreateOptions StripeTopupCreateOptions;
        protected static StripeTopup StripeTopup;
        protected static StripeCard StripeCard;

        private static StripeTopupService _stripeTopupService;
        private static string _createdStripeTopupId;

        Establish context = () =>
        {
            _stripeTopupService = new StripeTopupService();
            StripeTopupCreateOptions = test_data.stripe_topup_create_options.ValidToken("tok_visa");

            var stripeTopup = _stripeTopupService.Create(StripeTopupCreateOptions);
            _createdStripeTopupId = stripeTopup.Id;
        };

        Because of = () =>
        {
            StripeTopup = _stripeTopupService.Get(_createdStripeTopupId);
            StripeCard = StripeTopup.Source.Card;
        };

#pragma warning disable 169, 414
        Behaves_like<topup_behaviors> behaviors;
#pragma warning restore 169, 414

    }
}
