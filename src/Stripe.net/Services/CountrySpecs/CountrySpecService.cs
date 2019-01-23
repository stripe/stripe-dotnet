namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

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

        public override string BasePath => "/v1/country_specs";

        public virtual CountrySpec Get(string country, RequestOptions requestOptions = null)
        {
            return this.GetEntity(country, null, requestOptions);
        }

        public virtual Task<CountrySpec> GetAsync(string country, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(country, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<CountrySpec> List(CountrySpecListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<CountrySpec>> ListAsync(CountrySpecListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CountrySpec> ListAutoPaging(CountrySpecListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
