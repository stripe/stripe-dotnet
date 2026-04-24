// File generated from our OpenAPI spec
namespace Stripe.V2.Commerce.ProductCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ImportService : Service
    {
        internal ImportService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ImportService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a ProductCatalogImport.
        /// </summary>
        public virtual V2.Commerce.ProductCatalogImport Create(ImportCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Commerce.ProductCatalogImport>(BaseAddress.Api, HttpMethod.Post, $"/v2/commerce/product_catalog/imports", options, requestOptions);
        }

        /// <summary>
        /// Creates a ProductCatalogImport.
        /// </summary>
        public virtual Task<V2.Commerce.ProductCatalogImport> CreateAsync(ImportCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Commerce.ProductCatalogImport>(BaseAddress.Api, HttpMethod.Post, $"/v2/commerce/product_catalog/imports", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a ProductCatalogImport by ID.
        /// </summary>
        public virtual V2.Commerce.ProductCatalogImport Get(string id, ImportGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Commerce.ProductCatalogImport>(BaseAddress.Api, HttpMethod.Get, $"/v2/commerce/product_catalog/imports/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a ProductCatalogImport by ID.
        /// </summary>
        public virtual Task<V2.Commerce.ProductCatalogImport> GetAsync(string id, ImportGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Commerce.ProductCatalogImport>(BaseAddress.Api, HttpMethod.Get, $"/v2/commerce/product_catalog/imports/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of ProductCatalogImport objects.
        /// </summary>
        public virtual V2.StripeList<V2.Commerce.ProductCatalogImport> List(ImportListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Commerce.ProductCatalogImport>>(BaseAddress.Api, HttpMethod.Get, $"/v2/commerce/product_catalog/imports", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of ProductCatalogImport objects.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Commerce.ProductCatalogImport>> ListAsync(ImportListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Commerce.ProductCatalogImport>>(BaseAddress.Api, HttpMethod.Get, $"/v2/commerce/product_catalog/imports", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of ProductCatalogImport objects.
        /// </summary>
        public virtual IEnumerable<V2.Commerce.ProductCatalogImport> ListAutoPaging(ImportListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Commerce.ProductCatalogImport>($"/v2/commerce/product_catalog/imports", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of ProductCatalogImport objects.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Commerce.ProductCatalogImport> ListAutoPagingAsync(ImportListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Commerce.ProductCatalogImport>($"/v2/commerce/product_catalog/imports", options, requestOptions, cancellationToken);
        }
    }
}
