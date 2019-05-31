namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
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

        public BalanceService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/balance";

        public virtual Balance Get(RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Get, this.ClassUrl(), null, requestOptions);
        }

        public virtual Task<Balance> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Get, this.ClassUrl(), null, requestOptions, cancellationToken);
        }
    }
}
