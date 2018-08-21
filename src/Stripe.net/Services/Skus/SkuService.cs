namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class SkuService : BasicService<StripeSku>
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

        public virtual StripeSku Create(SkuCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/skus", requestOptions, options);
        }

        public virtual StripeSku Get(string skuId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions);
        }

        public virtual StripeSku Update(string skuId, SkuUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, options);
        }

        public virtual StripeList<StripeSku> List(SkuListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/skus", requestOptions, listOptions);
        }

        public virtual StripeSku Delete(string skuId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions);
        }

        public virtual Task<StripeSku> CreateAsync(SkuCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/skus", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeSku> GetAsync(string skuId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeSku> UpdateAsync(string skuId, SkuUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<StripeSku>> ListAsync(SkuListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/skus", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<StripeSku> DeleteAsync(string skuId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, cancellationToken);
        }
    }
}
