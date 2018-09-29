namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CountrySpecService : Service<CountrySpec>,
        IListable<CountrySpec, CountrySpecListOptions>,
        IRetrievable<CountrySpec>
    {
        public CountrySpecService()
            : base(null)
        {
        }

        public CountrySpecService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual CountrySpec Get(string country, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/country_specs/{country}", requestOptions);
        }

        public virtual StripeList<CountrySpec> List(CountrySpecListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/country_specs", requestOptions, options);
        }

        public virtual Task<CountrySpec> GetAsync(string country, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/country_specs/{country}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<CountrySpec>> ListAsync(CountrySpecListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/country_specs", requestOptions, cancellationToken, options);
        }
    }
}
