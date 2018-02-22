using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_topup_create_options
    {
        public static StripeTopupCreateOptions ValidToken(string _tokenId)
        {
            return new StripeTopupCreateOptions()
            {
                Amount = 2001,
                Currency = "usd",
                SourceTokenOrExistingSourceId = _tokenId
            };
        }
    }
}
