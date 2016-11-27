using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeAccountService : StripeBasicService<StripeAccount>
    {
        public StripeAccountService(string apiKey = null) : base(apiKey) { }



        //Sync
        public virtual StripeAccount Create(StripeAccountCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/accounts", requestOptions, createOptions);
        }

        public virtual StripeAccount Get(string accountId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/accounts/{accountId}", requestOptions);
        }

        public virtual StripeAccount Update(string accountId, StripeAccountUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/accounts/{accountId}", requestOptions, updateOptions);
        }

        public virtual StripeDeleted Delete(string accountId, StripeRequestOptions requestOptions = null)
        {
            return Delete($"{Urls.BaseUrl}/accounts/{accountId}", requestOptions);
        }



        //Async
        public virtual async Task<StripeAccount> CreateAsync(StripeAccountCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/accounts", requestOptions, cancellationToken, createOptions);
        }

        public virtual async Task<StripeAccount> GetAsync(string accountId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/accounts/{accountId}", requestOptions, cancellationToken);
        }

        public virtual async Task<StripeAccount> UpdateAsync(string accountId, StripeAccountUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/accounts/{accountId}", requestOptions, cancellationToken, updateOptions);
        }

        public virtual async Task<StripeDeleted> DeleteAsync(string accountId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteAsync($"{Urls.BaseUrl}/accounts/{accountId}", requestOptions, cancellationToken);
        }
    }
}
