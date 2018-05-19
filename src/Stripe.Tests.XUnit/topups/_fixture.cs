using System;
using System.Collections.Generic;
using System.Linq;

namespace Stripe.Tests.Xunit
{
    public class topups_fixture
    {
        public StripeTopupCreateOptions TopupCreateOptions { get; }
        public StripeTopupUpdateOptions TopupUpdateOptions { get; }
        public StripeTopupListOptions TopupListOptions { get; }

        public StripeTopup Topup { get; }
        public StripeTopup TopupUpdated { get; }
        public StripeTopup TopupRetrieved { get; }
        public StripeList<StripeTopup> TopupList { get; }

        public topups_fixture()
        {
            StripeSource source = new StripeSourceService(Cache.ApiKey).Create(new StripeSourceCreateOptions
            {
                Type = StripeSourceType.AchCreditTransfer,
                Currency = "usd",
                Owner = new StripeSourceOwner
                {
                    Email = "amount_4242@example.com"
                }
            });

            // Sleep for 5 seconds to ensure the Source is chargeable
            // 1 or 2 seconds are unfortunately not enough.
            System.Threading.Thread.Sleep(5000);

            TopupCreateOptions = new StripeTopupCreateOptions
            {
                Amount = 1000,
                Currency = "usd",
                Description = "Test Topup",
                SourceId = source.Id,
                StatementDescriptor = "Descriptor",
            };

            TopupUpdateOptions = new StripeTopupUpdateOptions
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "some-key", "some-value" }
                }
            };

            var service = new StripeTopupService(Cache.ApiKey);
            Topup = service.Create(TopupCreateOptions);
            TopupUpdated = service.Update(Topup.Id, TopupUpdateOptions);
            TopupRetrieved = service.Get(Topup.Id);

            TopupListOptions = new StripeTopupListOptions
            {
                Created = new StripeDateFilter { EqualTo = Topup.Created },
            };

            TopupList = service.List(TopupListOptions);
        }
    }
}
