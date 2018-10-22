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
        public BalanceService()
            : base(null)
        {
        }

        public BalanceService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/balance";

        public virtual Balance Get(RequestOptions requestOptions = null)
        {
            return this.GetRequest<Balance>(this.ClassUrl(), null, requestOptions);
        }

        public virtual Task<Balance> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetRequestAsync<Balance>(this.ClassUrl(), null, requestOptions, cancellationToken);
        }
    }
}
