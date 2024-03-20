// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CountrySpecService : Service<CountrySpec>,
        IListable<CountrySpec, CountrySpecListOptions>,
        IRetrievable<CountrySpec, CountrySpecGetOptions>
    {
        public CountrySpecService()
        {
        }

        public CountrySpecService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/country_specs";

        /// <summary>
        /// <p>Returns a Country Spec for a given Country code.</p>.
        /// </summary>
        public virtual CountrySpec Get(string id, CountrySpecGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CountrySpec>(HttpMethod.Get, $"/v1/country_specs/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a Country Spec for a given Country code.</p>.
        /// </summary>
        public virtual Task<CountrySpec> GetAsync(string id, CountrySpecGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CountrySpec>(HttpMethod.Get, $"/v1/country_specs/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all Country Spec objects available in the API.</p>.
        /// </summary>
        public virtual StripeList<CountrySpec> List(CountrySpecListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CountrySpec>>(HttpMethod.Get, $"/v1/country_specs", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all Country Spec objects available in the API.</p>.
        /// </summary>
        public virtual Task<StripeList<CountrySpec>> ListAsync(CountrySpecListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CountrySpec>>(HttpMethod.Get, $"/v1/country_specs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all Country Spec objects available in the API.</p>.
        /// </summary>
        public virtual IEnumerable<CountrySpec> ListAutoPaging(CountrySpecListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CountrySpec>($"/v1/country_specs", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all Country Spec objects available in the API.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<CountrySpec> ListAutoPagingAsync(CountrySpecListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CountrySpec>($"/v1/country_specs", options, requestOptions, cancellationToken);
        }
    }
}
