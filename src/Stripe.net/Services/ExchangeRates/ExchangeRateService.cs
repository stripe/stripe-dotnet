namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ExchangeRateService : Service<ExchangeRate>,
        IListable<ExchangeRate, ExchangeRateListOptions>,
        IRetrievable<ExchangeRate>
    {
        public ExchangeRateService()
            : base(null)
        {
        }

        public ExchangeRateService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual ExchangeRate Get(string currency, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/exchange_rates/{currency}", requestOptions);
        }

        public virtual StripeList<ExchangeRate> List(ExchangeRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/exchange_rates", requestOptions, options);
        }

        public virtual Task<ExchangeRate> GetAsync(string currency, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/exchange_rates/{currency}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<ExchangeRate>> ListAsync(ExchangeRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/exchange_rates", requestOptions, cancellationToken, options);
        }
    }
}
