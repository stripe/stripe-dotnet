using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_3d_secure
    {
        private static StripeToken _token;
        private static Stripe3DSecure _3DSecure;

        Establish context = () =>
        {
            // While we should not use raw PANs anymore in Tests we keep this code
            // to properly test the token creation API
            var tokenOptions = new StripeTokenCreateOptions()
            {
                Card = new StripeCreditCardOptions
                {
                    AddressCountry = "US",
                    AddressLine1 = "Line 1",
                    AddressLine2 = "Line 2",
                    AddressState = "Ca",
                    AddressZip = "90210",
                    Cvc = "123",
                    ExpirationMonth = 10,
                    ExpirationYear = 2021,
                    Name = "Jenny Rosen",
                    Number = "4000000000003055",
                },
            };

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
    }
}
