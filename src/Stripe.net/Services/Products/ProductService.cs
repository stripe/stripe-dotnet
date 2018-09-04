namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ProductService : BasicService<Product>,
        ICreatable<Product, ProductCreateOptions>,
        IDeletable<Product>,
        IListable<Product, ProductListOptions>,
        IRetrievable<Product>,
        IUpdatable<Product, ProductUpdateOptions>
    {
        public ProductService()
            : base(null)
        {
        }

        public ProductService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Product Create(ProductCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/products", requestOptions, options);
        }

        public virtual Product Get(string productId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/products/{WebUtility.UrlEncode(productId)}", requestOptions);
        }

        public virtual Product Update(string productId, ProductUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/products/{WebUtility.UrlEncode(productId)}", requestOptions, options);
        }

        public virtual StripeList<Product> List(ProductListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/products", requestOptions, listOptions);
        }

        public virtual Product Delete(string productId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/products/{WebUtility.UrlEncode(productId)}", requestOptions);
        }

        public virtual Task<Product> CreateAsync(ProductCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/products", requestOptions, cancellationToken, options);
        }

        public virtual Task<Product> GetAsync(string productId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/products/{WebUtility.UrlEncode(productId)}", requestOptions, cancellationToken);
        }

        public virtual Task<Product> UpdateAsync(string productId, ProductUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/products/{WebUtility.UrlEncode(productId)}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<Product>> ListAsync(ProductListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/products", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<Product> DeleteAsync(string productId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/products/{WebUtility.UrlEncode(productId)}", requestOptions, cancellationToken);
        }
    }
}
