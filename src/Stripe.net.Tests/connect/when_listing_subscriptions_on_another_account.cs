using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    [Ignore(@"
        This test requires that you setup your account as a Stripe Connect platform and have successfully connected an account via oauth. On the connected account, you will need the
        connected account id (starts with 'acct_' - the StripeUserId property from your StripeOAuthToken). You can get this value by debugging the 'when_authorizing_an_account' test
        and inspecting the response. Once you have that value, enter it below for _connectedAccountCustomerId.

        When that is complete, make sure the connected account has a customer with the id you put in below (_connectedAccountCustomerId) and is tied to at least one subscription.
    ")]
    public class when_listing_subscriptions_on_another_account
    {
        private static string _connectedAccountId = "acct_****";
        private static string _connectedAccountCustomerId = "cus_****";

        private static List<StripeSubscription> _stripeSubscriptionList;
        private static StripeSubscriptionService _stripeSubscriptionService;

        Establish context = () =>
            _stripeSubscriptionService = new StripeSubscriptionService();

        Because of = () =>
        {
            var requestOptions = new StripeRequestOptions() { StripeConnectAccountId = _connectedAccountId };
            _stripeSubscriptionList = _stripeSubscriptionService.List(_connectedAccountCustomerId, null, requestOptions).ToList();
        };

        It should_have_at_lest_one_subscription = () =>
            _stripeSubscriptionList.Count().ShouldBeGreaterThanOrEqualTo(1);
    }
}
