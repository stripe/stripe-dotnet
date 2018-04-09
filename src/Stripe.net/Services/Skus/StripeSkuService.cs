using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSkuService : StripeBasicService<StripeSku>
    {
        public StripeSkuService() : base(null) { }
        public StripeSkuService(string apiKey) : base(apiKey) { }

        public bool ExpandProduct { get; set; }



        // Sync
        public virtual StripeSku Create(StripeSkuCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/skus", requestOptions, options);
        }

        public virtual StripeSku Get(string skuId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions);
        }

        public virtual StripeSku Update(string skuId, StripeSkuUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, options);
        }

        public virtual StripeList<StripeSku> List(StripeSkuListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.BaseUrl}/skus", requestOptions, listOptions);
        }

        public virtual StripeDeleted Delete(string skuId, StripeRequestOptions requestOptions = null)
        {
            return DeleteEntity($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions);
        }



        // Async
        public virtual Task<StripeSku> CreateAsync(StripeSkuCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/skus", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeSku> GetAsync(string skuId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeSku> UpdateAsync(string skuId, StripeSkuUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<StripeSku>> ListAsync(StripeSkuListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/skus", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<StripeDeleted> DeleteAsync(string skuId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteEntityAsync($"{Urls.BaseUrl}/skus/{WebUtility.UrlEncode(skuId)}", requestOptions, cancellationToken);
        }
    }
}
