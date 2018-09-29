namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class BalanceService : Service<Balance>,
        ISingletonRetrievable<Balance>
    {
        private static string classUrl = Urls.BaseUrl + "/balance";

        public BalanceService()
            : base(null)
        {
        }

        public BalanceService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Balance Get(RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/balance", requestOptions);
        }

        public virtual Task<Balance> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/balance", requestOptions, cancellationToken);
        }
    }
}
