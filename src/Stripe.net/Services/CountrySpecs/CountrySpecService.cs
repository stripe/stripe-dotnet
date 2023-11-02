// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

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
            return this.Request<CountrySpec>(HttpMethod.Get, $"/v1/country_specs/{id}", options, requestOptions);
        }

        public virtual Task<CountrySpec> GetAsync(string id, CountrySpecGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CountrySpec>(HttpMethod.Get, $"/v1/country_specs/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CountrySpec> List(CountrySpecListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CountrySpec>>(HttpMethod.Get, $"/v1/country_specs", options, requestOptions);
        }

        public virtual Task<StripeList<CountrySpec>> ListAsync(CountrySpecListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CountrySpec>>(HttpMethod.Get, $"/v1/country_specs", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CountrySpec> ListAutoPaging(CountrySpecListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CountrySpec>($"/v1/country_specs", options, requestOptions);
        }

        public virtual IAsyncEnumerable<CountrySpec> ListAutoPagingAsync(CountrySpecListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CountrySpec>($"/v1/country_specs", options, requestOptions, cancellationToken);
        }
    }
}
