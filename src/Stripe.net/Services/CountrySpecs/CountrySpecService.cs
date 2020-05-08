namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CountrySpecService : Service<CountrySpec>,
        IListable<CountrySpec, CountrySpecListOptions>,
        IRetrievable<CountrySpec, CountrySpecGetOptions>
    {
        public CountrySpecService()
            : base(null)
        {
        }

        public CountrySpecService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/country_specs";

        public virtual CountrySpec Get(string id, CountrySpecGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<CountrySpec> GetAsync(string id, CountrySpecGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CountrySpec> List(CountrySpecListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<CountrySpec>> ListAsync(CountrySpecListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CountrySpec> ListAutoPaging(CountrySpecListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
