//using System.Configuration;
//using Machine.Specifications;

//namespace Stripe.Tests
//{
//    [Ignore(@"
//        This test requires that you first setup your account as a Stripe Connect platform. Then, from another stripe account, click a link to your
//        connect url with the platform account client id (example below). Once you have connected the stripe account, you can run this test to finish connecting 
//        the user to your platform. Note: you will want to debug and inspect the _stripeOAuthToken to get the StripeUserId if you plan to run the 'when_listing_subscriptions_on_another_account'
//        after this test.

//        Example Stripe Connect URL: https://connect.stripe.com/oauth/authorize?response_type=code&client_id=[your_client_id]&scope=read_write

//        After this step, you will receive a code. Enter the code below in the _code property and execute the test.
//    ")]
//    public class when_authorizing_an_account
//    {
//        private const string _code = "ac_****";

//        private static StripeOAuthTokenCreateOptions _stripeOAuthTokeCreateOptions;
//        private static StripeOAuthToken _stripeOAuthToken;
//        private static StripeOAuthTokenService _stripeOAuthTokenService;

//        Establish context = () =>
//        {
//            _stripeOAuthTokenService = new StripeOAuthTokenService();
//            _stripeOAuthTokeCreateOptions = new StripeOAuthTokenCreateOptions()
//            {
//                ClientSecret = ConfigurationManager.AppSettings["StripeApiKey"],
//                Code = _code,
//                GrantType = "authorization_code"
//            };
//        };

//        Because of = () =>
//            _stripeOAuthToken = _stripeOAuthTokenService.Create(_stripeOAuthTokeCreateOptions);

//        It should_not_have_an_error = () =>
//            _stripeOAuthToken.Error.ShouldBeNull();

//        It should_not_have_an_error_description = () =>
//            _stripeOAuthToken.ErrorDescription.ShouldBeNull();

//        It should_have_a_stripeuserid = () =>
//            _stripeOAuthToken.StripeUserId.ShouldStartWith("acct_");

//        It should_have_a_bearer_token_type = () =>
//            _stripeOAuthToken.TokenType.ShouldEqual("bearer");
//    }
//}
