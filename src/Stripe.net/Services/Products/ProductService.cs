namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProductService : Service<Product>,
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

        public override string BasePath => "/v1/products";

        public virtual Product Create(ProductCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Product> CreateAsync(ProductCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Product Delete(string productId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(productId, null, requestOptions);
        }

        public virtual Task<Product> DeleteAsync(string productId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(productId, null, requestOptions, cancellationToken);
        }

        public virtual Product Get(string productId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(productId, null, requestOptions);
        }

        public virtual Task<Product> GetAsync(string productId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(productId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Product> List(ProductListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Product>> ListAsync(ProductListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Product> ListAutoPaging(ProductListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Product Update(string productId, ProductUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(productId, options, requestOptions);
        }

        public virtual Task<Product> UpdateAsync(string productId, ProductUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(productId, options, requestOptions, cancellationToken);
        }
    }
}
