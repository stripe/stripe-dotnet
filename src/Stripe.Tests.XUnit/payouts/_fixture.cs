using System;
using System.Collections.Generic;
using System.Linq;

namespace Stripe.Tests.Xunit
{
    public class payouts_fixture
    {
        public StripePayoutCreateOptions PayoutCreateOptions { get; }
        public StripePayoutUpdateOptions PayoutUpdateOptions { get; }
        public StripePayoutListOptions PayoutListOptions { get; }

        public StripePayout Payout { get; }
        public StripePayout PayoutUpdated { get; }
        public StripePayout PayoutRetrieved { get; }
        public StripeList<StripePayout> PayoutList { get; }

        public payouts_fixture()
        {
            // make sure the account has sufficient funds first
            new StripeChargeService(Cache.ApiKey).Create(new StripeChargeCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                SourceTokenOrExistingSourceId = "tok_bypassPending"
            });

            PayoutCreateOptions = new StripePayoutCreateOptions
            {
                Amount = 1000,
                Currency = "usd"
            };

            PayoutUpdateOptions = new StripePayoutUpdateOptions
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "some-key", "some-value" }
                }
            };

            var service = new StripePayoutService(Cache.ApiKey);
            Payout = service.Create(PayoutCreateOptions);
            PayoutUpdated = service.Update(Payout.Id, PayoutUpdateOptions);
            PayoutRetrieved = service.Get(Payout.Id);

            PayoutListOptions = new StripePayoutListOptions
            {
                Created = new StripeDateFilter { EqualTo = Payout.Created },
                ArrivalDate = new StripeDateFilter { EqualTo = Payout.ArrivalDate }
            };

            PayoutList = service.List(PayoutListOptions);
        }
    }
}
