// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProductService : Service<Product>,
        ICreatable<Product, ProductCreateOptions>,
        IDeletable<Product, ProductDeleteOptions>,
        IListable<Product, ProductListOptions>,
        IRetrievable<Product, ProductGetOptions>,
        ISearchable<Product, ProductSearchOptions>,
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

        public virtual Product Delete(string id, ProductDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, options, requestOptions);
        }

        public virtual Task<Product> DeleteAsync(string id, ProductDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual Product Get(string id, ProductGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Product> GetAsync(string id, ProductGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
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

        public virtual IAsyncEnumerable<Product> ListAutoPagingAsync(ProductListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual StripeSearchResult<Product> Search(ProductSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeSearchResult<Product>>(HttpMethod.Get, $"{this.InstanceUrl("search")}", options, requestOptions);
        }

        public virtual Task<StripeSearchResult<Product>> SearchAsync(ProductSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeSearchResult<Product>>(HttpMethod.Get, $"{this.InstanceUrl("search")}", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Product> SearchAutoPaging(ProductSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.SearchRequestAutoPaging<Product>($"{this.InstanceUrl("search")}", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Product> SearchAutoPagingAsync(ProductSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.SearchRequestAutoPagingAsync<Product>($"{this.InstanceUrl("search")}", options, requestOptions, cancellationToken);
        }

        public virtual Product Update(string id, ProductUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Product> UpdateAsync(string id, ProductUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
