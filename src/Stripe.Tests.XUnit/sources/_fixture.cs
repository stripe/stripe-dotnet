using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public class sources_fixture : IDisposable
    {
        public StripeSourceCreateOptions SourceCreateOptions { get; }
        public StripeSourceUpdateOptions SourceUpdateOptions { get; }

        public StripeSource Source { get; }
        public StripeSource SourceUpdated { get; }
        public StripeSource SourceRetrieved { get; }

        public sources_fixture()
        {
            SourceCreateOptions = new StripeSourceCreateOptions
            {
                Type = StripeSourceType.Bitcoin,
                Amount = 1001,
                Currency = "usd",
                Owner = new StripeSourceOwner
                {
                    Email = "jimmy@hendrix.com",
                    CityOrTown = "Mayberry",
                    State = "NC"
                }
            };

            SourceUpdateOptions = new StripeSourceUpdateOptions
            {
                Owner = new StripeSourceOwner
                {
                    Email = "hendrix@jimmy.com"
                }
            };

            var service = new StripeSourceService(Cache.ApiKey);
            Source = service.Create(SourceCreateOptions);
            SourceUpdated = service.Update(Source.Id, SourceUpdateOptions);
            SourceRetrieved = service.Get(Source.Id);
        }

        public void Dispose()
        {
            // not implemented :(
            // new StripeSourceService(Cache.ApiKey).Delete(Source.Id);
        }
    }
}
