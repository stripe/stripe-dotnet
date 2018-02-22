using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_updating_a_topup
    {
        private static StripeTopupUpdateOptions _stripeTopupUpdateOptions;
        private static StripeTopup _stripeTopup;
        private static StripeTopupService _stripeTopupService;
        private static string _createdStripeTopupId;

        Establish context = () =>
        {
            _stripeTopupService = new StripeTopupService();

            var stripeTopup = _stripeTopupService.Create(test_data.stripe_topup_create_options.ValidToken("tok_visa"));
            _createdStripeTopupId = stripeTopup.Id;

            _stripeTopupUpdateOptions = test_data.stripe_topup_update_options.Valid();
        };

        Because of = () =>
            _stripeTopup = _stripeTopupService.Update(_createdStripeTopupId, _stripeTopupUpdateOptions);

        It should_have_metadata = () =>
            _stripeTopup.Metadata.Count.ShouldBeGreaterThan(0);

        It should_have_the_correct_metadata = () =>
            _stripeTopup.Metadata.ShouldContainOnly(_stripeTopupUpdateOptions.Metadata);
    }
}
