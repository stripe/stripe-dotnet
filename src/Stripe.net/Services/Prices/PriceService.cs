// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PriceService : Service<Price>,
        ICreatable<Price, PriceCreateOptions>,
        IListable<Price, PriceListOptions>,
        IRetrievable<Price, PriceGetOptions>,
        ISearchable<Price, PriceSearchOptions>,
        IUpdatable<Price, PriceUpdateOptions>
    {
        public PriceService()
        {
        }

        public PriceService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/prices";

        /// <summary>
        /// <p>Creates a new price for an existing product. The price can be recurring or
        /// one-time.</p>.
        /// </summary>
        public virtual Price Create(PriceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Price>(HttpMethod.Post, $"/v1/prices", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new price for an existing product. The price can be recurring or
        /// one-time.</p>.
        /// </summary>
        public virtual Task<Price> CreateAsync(PriceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Price>(HttpMethod.Post, $"/v1/prices", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the price with the given ID.</p>.
        /// </summary>
        public virtual Price Get(string id, PriceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Price>(HttpMethod.Get, $"/v1/prices/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the price with the given ID.</p>.
        /// </summary>
        public virtual Task<Price> GetAsync(string id, PriceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Price>(HttpMethod.Get, $"/v1/prices/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your active prices, excluding <a
        /// href="https://stripe.com/docs/products-prices/pricing-models#inline-pricing">inline
        /// prices</a>. For the list of inactive prices, set <c>active</c> to false.</p>.
        /// </summary>
        public virtual StripeList<Price> List(PriceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Price>>(HttpMethod.Get, $"/v1/prices", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your active prices, excluding <a
        /// href="https://stripe.com/docs/products-prices/pricing-models#inline-pricing">inline
        /// prices</a>. For the list of inactive prices, set <c>active</c> to false.</p>.
        /// </summary>
        public virtual Task<StripeList<Price>> ListAsync(PriceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Price>>(HttpMethod.Get, $"/v1/prices", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your active prices, excluding <a
        /// href="https://stripe.com/docs/products-prices/pricing-models#inline-pricing">inline
        /// prices</a>. For the list of inactive prices, set <c>active</c> to false.</p>.
        /// </summary>
        public virtual IEnumerable<Price> ListAutoPaging(PriceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Price>($"/v1/prices", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your active prices, excluding <a
        /// href="https://stripe.com/docs/products-prices/pricing-models#inline-pricing">inline
        /// prices</a>. For the list of inactive prices, set <c>active</c> to false.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Price> ListAutoPagingAsync(PriceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Price>($"/v1/prices", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Search for prices you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual StripeSearchResult<Price> Search(PriceSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeSearchResult<Price>>(HttpMethod.Get, $"/v1/prices/search", options, requestOptions);
        }

        /// <summary>
        /// <p>Search for prices you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual Task<StripeSearchResult<Price>> SearchAsync(PriceSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeSearchResult<Price>>(HttpMethod.Get, $"/v1/prices/search", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Search for prices you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual IEnumerable<Price> SearchAutoPaging(PriceSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.SearchRequestAutoPaging<Price>($"/v1/prices/search", options, requestOptions);
        }

        /// <summary>
        /// <p>Search for prices you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Price> SearchAutoPagingAsync(PriceSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.SearchRequestAutoPagingAsync<Price>($"/v1/prices/search", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specified price by setting the values of the parameters passed. Any
        /// parameters not provided are left unchanged.</p>.
        /// </summary>
        public virtual Price Update(string id, PriceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Price>(HttpMethod.Post, $"/v1/prices/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specified price by setting the values of the parameters passed. Any
        /// parameters not provided are left unchanged.</p>.
        /// </summary>
        public virtual Task<Price> UpdateAsync(string id, PriceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Price>(HttpMethod.Post, $"/v1/prices/{id}", options, requestOptions, cancellationToken);
        }
    }
}
