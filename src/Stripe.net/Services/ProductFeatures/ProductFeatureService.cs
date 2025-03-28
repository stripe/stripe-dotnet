// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProductFeatureService : Service,
        INestedCreatable<ProductFeature, ProductFeatureCreateOptions>,
        INestedDeletable<ProductFeature, ProductFeatureDeleteOptions>,
        INestedListable<ProductFeature, ProductFeatureListOptions>,
        INestedRetrievable<ProductFeature, ProductFeatureGetOptions>
    {
        public ProductFeatureService()
        {
        }

        internal ProductFeatureService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ProductFeatureService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a product_feature, which represents a feature attachment to a product</p>.
        /// </summary>
        public virtual ProductFeature Create(string parentId, ProductFeatureCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ProductFeature>(BaseAddress.Api, HttpMethod.Post, $"/v1/products/{WebUtility.UrlEncode(parentId)}/features", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a product_feature, which represents a feature attachment to a product</p>.
        /// </summary>
        public virtual Task<ProductFeature> CreateAsync(string parentId, ProductFeatureCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ProductFeature>(BaseAddress.Api, HttpMethod.Post, $"/v1/products/{WebUtility.UrlEncode(parentId)}/features", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deletes the feature attachment to a product</p>.
        /// </summary>
        public virtual ProductFeature Delete(string parentId, string id, ProductFeatureDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ProductFeature>(BaseAddress.Api, HttpMethod.Delete, $"/v1/products/{WebUtility.UrlEncode(parentId)}/features/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Deletes the feature attachment to a product</p>.
        /// </summary>
        public virtual Task<ProductFeature> DeleteAsync(string parentId, string id, ProductFeatureDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ProductFeature>(BaseAddress.Api, HttpMethod.Delete, $"/v1/products/{WebUtility.UrlEncode(parentId)}/features/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a product_feature, which represents a feature attachment to a product</p>.
        /// </summary>
        public virtual ProductFeature Get(string parentId, string id, ProductFeatureGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ProductFeature>(BaseAddress.Api, HttpMethod.Get, $"/v1/products/{WebUtility.UrlEncode(parentId)}/features/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a product_feature, which represents a feature attachment to a product</p>.
        /// </summary>
        public virtual Task<ProductFeature> GetAsync(string parentId, string id, ProductFeatureGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ProductFeature>(BaseAddress.Api, HttpMethod.Get, $"/v1/products/{WebUtility.UrlEncode(parentId)}/features/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of features for a product</p>.
        /// </summary>
        public virtual StripeList<ProductFeature> List(string parentId, ProductFeatureListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ProductFeature>>(BaseAddress.Api, HttpMethod.Get, $"/v1/products/{WebUtility.UrlEncode(parentId)}/features", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of features for a product</p>.
        /// </summary>
        public virtual Task<StripeList<ProductFeature>> ListAsync(string parentId, ProductFeatureListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ProductFeature>>(BaseAddress.Api, HttpMethod.Get, $"/v1/products/{WebUtility.UrlEncode(parentId)}/features", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of features for a product</p>.
        /// </summary>
        public virtual IEnumerable<ProductFeature> ListAutoPaging(string parentId, ProductFeatureListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ProductFeature>($"/v1/products/{WebUtility.UrlEncode(parentId)}/features", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of features for a product</p>.
        /// </summary>
        public virtual IAsyncEnumerable<ProductFeature> ListAutoPagingAsync(string parentId, ProductFeatureListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ProductFeature>($"/v1/products/{WebUtility.UrlEncode(parentId)}/features", options, requestOptions, cancellationToken);
        }
    }
}
