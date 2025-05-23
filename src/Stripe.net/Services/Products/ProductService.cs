// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProductService : Service,
        ICreatable<Product, ProductCreateOptions>,
        IDeletable<Product, ProductDeleteOptions>,
        IListable<Product, ProductListOptions>,
        IRetrievable<Product, ProductGetOptions>,
        ISearchable<Product, ProductSearchOptions>,
        IUpdatable<Product, ProductUpdateOptions>
    {
        private ProductFeatureService features;

        public ProductService()
        {
        }

        internal ProductService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ProductService(IStripeClient client)
            : base(client)
        {
        }

        public virtual ProductFeatureService Features => this.features ??= new ProductFeatureService(
            this.Requestor);

        /// <summary>
        /// <p>Creates a new product object.</p>.
        /// </summary>
        public virtual Product Create(ProductCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Product>(BaseAddress.Api, HttpMethod.Post, $"/v1/products", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new product object.</p>.
        /// </summary>
        public virtual Task<Product> CreateAsync(ProductCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Product>(BaseAddress.Api, HttpMethod.Post, $"/v1/products", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Delete a product. Deleting a product is only possible if it has no prices associated
        /// with it. Additionally, deleting a product with <c>type=good</c> is only possible if it
        /// has no SKUs associated with it.</p>.
        /// </summary>
        public virtual Product Delete(string id, ProductDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Product>(BaseAddress.Api, HttpMethod.Delete, $"/v1/products/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Delete a product. Deleting a product is only possible if it has no prices associated
        /// with it. Additionally, deleting a product with <c>type=good</c> is only possible if it
        /// has no SKUs associated with it.</p>.
        /// </summary>
        public virtual Task<Product> DeleteAsync(string id, ProductDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Product>(BaseAddress.Api, HttpMethod.Delete, $"/v1/products/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing product. Supply the unique product ID from
        /// either a product creation request or the product list, and Stripe will return the
        /// corresponding product information.</p>.
        /// </summary>
        public virtual Product Get(string id, ProductGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Product>(BaseAddress.Api, HttpMethod.Get, $"/v1/products/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing product. Supply the unique product ID from
        /// either a product creation request or the product list, and Stripe will return the
        /// corresponding product information.</p>.
        /// </summary>
        public virtual Task<Product> GetAsync(string id, ProductGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Product>(BaseAddress.Api, HttpMethod.Get, $"/v1/products/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your products. The products are returned sorted by creation date,
        /// with the most recently created products appearing first.</p>.
        /// </summary>
        public virtual StripeList<Product> List(ProductListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Product>>(BaseAddress.Api, HttpMethod.Get, $"/v1/products", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your products. The products are returned sorted by creation date,
        /// with the most recently created products appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Product>> ListAsync(ProductListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Product>>(BaseAddress.Api, HttpMethod.Get, $"/v1/products", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your products. The products are returned sorted by creation date,
        /// with the most recently created products appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<Product> ListAutoPaging(ProductListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Product>($"/v1/products", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your products. The products are returned sorted by creation date,
        /// with the most recently created products appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Product> ListAutoPagingAsync(ProductListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Product>($"/v1/products", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Search for products you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual StripeSearchResult<Product> Search(ProductSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeSearchResult<Product>>(BaseAddress.Api, HttpMethod.Get, $"/v1/products/search", options, requestOptions);
        }

        /// <summary>
        /// <p>Search for products you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual Task<StripeSearchResult<Product>> SearchAsync(ProductSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeSearchResult<Product>>(BaseAddress.Api, HttpMethod.Get, $"/v1/products/search", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Search for products you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual IEnumerable<Product> SearchAutoPaging(ProductSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.SearchRequestAutoPaging<Product>($"/v1/products/search", options, requestOptions);
        }

        /// <summary>
        /// <p>Search for products you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Product> SearchAutoPagingAsync(ProductSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.SearchRequestAutoPagingAsync<Product>($"/v1/products/search", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specific product by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged.</p>.
        /// </summary>
        public virtual Product Update(string id, ProductUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Product>(BaseAddress.Api, HttpMethod.Post, $"/v1/products/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specific product by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged.</p>.
        /// </summary>
        public virtual Task<Product> UpdateAsync(string id, ProductUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Product>(BaseAddress.Api, HttpMethod.Post, $"/v1/products/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
