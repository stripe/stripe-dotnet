namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class StripeSkuService : StripeBasicService<StripeSku>
    {
        public StripeSkuService()
            : base(null)
        {
        }

        public StripeSkuService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandProduct { get; set; }

        public virtual StripeSku Create(StripeSkuCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/skus", requestOptions, options);
        }

        public virtual StripeSku Get(string skuId, StripeRequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions);
        }

        public virtual StripeSku Update(string skuId, StripeSkuUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, options);
        }

        public virtual StripeList<StripeSku> List(StripeSkuListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/skus", requestOptions, listOptions);
        }

        public virtual StripeSku Delete(string skuId, StripeRequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions);
        }

        public virtual Task<StripeSku> CreateAsync(StripeSkuCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/skus", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeSku> GetAsync(string skuId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeSku> UpdateAsync(string skuId, StripeSkuUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<StripeSku>> ListAsync(StripeSkuListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/skus", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<StripeSku> DeleteAsync(string skuId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, cancellationToken);
        }
    }
}
