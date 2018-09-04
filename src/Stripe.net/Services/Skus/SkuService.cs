namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class SkuService : BasicService<Sku>,
        ICreatable<Sku, SkuCreateOptions>,
        IDeletable<Sku>,
        IListable<Sku, SkuListOptions>,
        IRetrievable<Sku>,
        IUpdatable<Sku, SkuUpdateOptions>
    {
        public SkuService()
            : base(null)
        {
        }

        public SkuService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandProduct { get; set; }

        public virtual Sku Create(SkuCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/skus", requestOptions, options);
        }

        public virtual Sku Get(string skuId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions);
        }

        public virtual Sku Update(string skuId, SkuUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, options);
        }

        public virtual StripeList<Sku> List(SkuListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/skus", requestOptions, listOptions);
        }

        public virtual Sku Delete(string skuId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions);
        }

        public virtual Task<Sku> CreateAsync(SkuCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/skus", requestOptions, cancellationToken, options);
        }

        public virtual Task<Sku> GetAsync(string skuId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, cancellationToken);
        }

        public virtual Task<Sku> UpdateAsync(string skuId, SkuUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<Sku>> ListAsync(SkuListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/skus", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<Sku> DeleteAsync(string skuId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, cancellationToken);
        }
    }
}
