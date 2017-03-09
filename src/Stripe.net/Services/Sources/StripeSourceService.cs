using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSourceService : StripeBasicService<StripeSource>
    {
        public StripeSourceService(string apiKey = null) : base(apiKey) { }



        // Sync
        public virtual StripeSource Create(StripeSourceCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/sources", requestOptions, options);
        }

        public virtual StripeSource Get(string sourceId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions);
        }

        public virtual StripeSource Update(string sourceId, StripeSourceUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions, options);
        }

        // not available :(
        //public virtual StripeDeleted Delete(string sourceId, StripeRequestOptions requestOptions = null)
        //{
        //    return DeleteEntity($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions);
        //}



        // Async
        public virtual Task<StripeSource> CreateAsync(StripeSourceCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/sources", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeSource> GetAsync(string sourceId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeSource> UpdateAsync(string sourceId, StripeSourceUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions, cancellationToken, options);
        }

        // not available :(
        //public virtual Task<StripeDeleted> DeleteAsync(string sourceId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return DeleteEntityAsync($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions, cancellationToken);
        //}
    }
}
