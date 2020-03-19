namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProductService : Service<Product>,
        ICreatable<Product, ProductCreateOptions>,
        IDeletable<Product, ProductDeleteOptions>,
        IListable<Product, ProductListOptions>,
        IRetrievable<Product, ProductGetOptions>,
        IUpdatable<Product, ProductUpdateOptions>
    {
        public ProductService()
            : base(null)
        {
        }

        public ProductService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/products";

        public virtual Product Create(ProductCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Product> CreateAsync(ProductCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Product Delete(string productId, ProductDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(productId, options, requestOptions);
        }

        public virtual Task<Product> DeleteAsync(string productId, ProductDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(productId, options, requestOptions, cancellationToken);
        }

        public virtual Product Get(string productId, ProductGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(productId, options, requestOptions);
        }

        public virtual Task<Product> GetAsync(string productId, ProductGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(productId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Product> List(ProductListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Product>> ListAsync(ProductListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Product> ListAutoPaging(ProductListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Product> ListAutoPagingAsync(ProductListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual Product Update(string productId, ProductUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(productId, options, requestOptions);
        }

        public virtual Task<Product> UpdateAsync(string productId, ProductUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(productId, options, requestOptions, cancellationToken);
        }
    }
}
