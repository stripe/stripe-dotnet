// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProductService : Service<Product>,
        IListable<Product, ProductListOptions>,
        IRetrievable<Product, ProductGetOptions>
    {
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

        /// <summary>
        /// <p>Retrieves the details of a Climate product with the given ID.</p>.
        /// </summary>
        public virtual Product Get(string id, ProductGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Product>(BaseAddress.Api, HttpMethod.Get, $"/v1/climate/products/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a Climate product with the given ID.</p>.
        /// </summary>
        public virtual Task<Product> GetAsync(string id, ProductGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Product>(BaseAddress.Api, HttpMethod.Get, $"/v1/climate/products/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all available Climate product objects.</p>.
        /// </summary>
        public virtual StripeList<Product> List(ProductListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Product>>(BaseAddress.Api, HttpMethod.Get, $"/v1/climate/products", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all available Climate product objects.</p>.
        /// </summary>
        public virtual Task<StripeList<Product>> ListAsync(ProductListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Product>>(BaseAddress.Api, HttpMethod.Get, $"/v1/climate/products", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all available Climate product objects.</p>.
        /// </summary>
        public virtual IEnumerable<Product> ListAutoPaging(ProductListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Product>($"/v1/climate/products", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all available Climate product objects.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Product> ListAutoPagingAsync(ProductListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Product>($"/v1/climate/products", options, requestOptions, cancellationToken);
        }
    }
}
