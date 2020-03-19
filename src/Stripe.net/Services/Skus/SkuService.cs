namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class SkuService : Service<Sku>,
        ICreatable<Sku, SkuCreateOptions>,
        IDeletable<Sku, SkuDeleteOptions>,
        IListable<Sku, SkuListOptions>,
        IRetrievable<Sku, SkuGetOptions>,
        IUpdatable<Sku, SkuUpdateOptions>
    {
        public SkuService()
            : base(null)
        {
        }

        public SkuService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/skus";

        public virtual Sku Create(SkuCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Sku> CreateAsync(SkuCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Sku Delete(string skuId, SkuDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(skuId, options, requestOptions);
        }

        public virtual Task<Sku> DeleteAsync(string skuId, SkuDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(skuId, options, requestOptions, cancellationToken);
        }

        public virtual Sku Get(string skuId, SkuGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(skuId, options, requestOptions);
        }

        public virtual Task<Sku> GetAsync(string skuId, SkuGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(skuId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Sku> List(SkuListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Sku>> ListAsync(SkuListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Sku> ListAutoPaging(SkuListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Sku> ListAutoPagingAsync(SkuListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual Sku Update(string skuId, SkuUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(skuId, options, requestOptions);
        }

        public virtual Task<Sku> UpdateAsync(string skuId, SkuUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(skuId, options, requestOptions, cancellationToken);
        }
    }
}
