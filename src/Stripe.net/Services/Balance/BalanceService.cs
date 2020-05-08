namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class BalanceService : Service<Balance>,
        IRetrievable<Balance, BalanceGetOptions>
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

        public virtual Balance Get(string id, BalanceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Balance> GetAsync(string id, BalanceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
