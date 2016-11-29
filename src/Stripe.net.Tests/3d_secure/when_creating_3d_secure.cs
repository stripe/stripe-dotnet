using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_3d_secure
    {
        private static StripeToken _token;
        private static Stripe3DSecure _3DSecure;

        Establish context = () =>
        {
            var tokenOptions = test_data.stripe_token_create_options.Valid();
            tokenOptions.Card.Number = "4000000000003055";

            _token = new StripeTokenService().Create(tokenOptions);
        };

        Because of = () =>
            _3DSecure = new Stripe3DSecureService().Create(new Stripe3DSecureCreateOptions
            {
                Amount = 1000,
                Currency = "usd",
                ReturnUrl = "http://3d-secure-needs-no-glasses.com",
                CardTokenOrCardId = _token.Id
            });

        It should_have_a_3d_secure_object = () =>
            _3DSecure.ShouldNotBeNull();

        It should_have_the_right_amount = () =>
            _3DSecure.Amount.ShouldEqual(1000);

        It should_have_the_right_currency = () =>
            _3DSecure.Currency.ShouldEqual("usd");

        It should_have_a_redirect_url = () =>
            _3DSecure.RedirectUrl.ShouldContain("http");

        It should_have_a_card_with_3d_secure_hash = () =>
            _3DSecure.Card.ThreeDSecure.Keys.ShouldContain("supported");
    }
}
