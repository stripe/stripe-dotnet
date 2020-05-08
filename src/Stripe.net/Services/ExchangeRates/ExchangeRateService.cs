namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ExchangeRateService : Service<ExchangeRate>,
        IListable<ExchangeRate, ExchangeRateListOptions>,
        IRetrievable<ExchangeRate, ExchangeRateGetOptions>
    {
        public ExchangeRateService()
            : base(null)
        {
        }

        public ExchangeRateService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/exchange_rates";

        public virtual ExchangeRate Get(string id, ExchangeRateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<ExchangeRate> GetAsync(string id, ExchangeRateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ExchangeRate> List(ExchangeRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ExchangeRate>> ListAsync(ExchangeRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ExchangeRate> ListAutoPaging(ExchangeRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
