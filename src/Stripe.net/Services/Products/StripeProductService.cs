using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeProductService : StripeBasicService<StripeProduct>
    {
        public StripeProductService() : base(null) { }
        public StripeProductService(string apiKey) : base(apiKey) { }



        // Sync
        public virtual StripeProduct Create(StripeProductCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/products", requestOptions, options);
        }

        public virtual StripeProduct Get(string productId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/products/{WebUtility.UrlEncode(productId)}", requestOptions);
        }

        public virtual StripeProduct Update(string productId, StripeProductUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/products/{WebUtility.UrlEncode(productId)}", requestOptions, options);
        }

        public virtual StripeList<StripeProduct> List(StripeProductListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.BaseUrl}/products", requestOptions, listOptions);
        }

        public virtual StripeDeleted Delete(string productId, StripeRequestOptions requestOptions = null)
        {
            return DeleteEntity($"{Urls.BaseUrl}/products/{WebUtility.UrlEncode(productId)}", requestOptions);
        }



        // Async
        public virtual Task<StripeProduct> CreateAsync(StripeProductCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/products", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeProduct> GetAsync(string productId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/products/{WebUtility.UrlEncode(productId)}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeProduct> UpdateAsync(string productId, StripeProductUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/products/{WebUtility.UrlEncode(productId)}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<StripeProduct>> ListAsync(StripeProductListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/products", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<StripeDeleted> DeleteAsync(string productId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteEntityAsync($"{Urls.BaseUrl}/products/{WebUtility.UrlEncode(productId)}", requestOptions, cancellationToken);
        }
    }
}
