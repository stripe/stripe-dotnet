using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeExternalAccountService : StripeBasicService<StripeExternalAccount>
    {
        public StripeExternalAccountService() : base(null) { }
        public StripeExternalAccountService(string apiKey) : base(apiKey) { }



        // Sync
        public virtual StripeExternalAccount Create(string accountId, StripeExternalAccountCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts", requestOptions, options);
        }

        public virtual StripeExternalAccount Get(string accountId, string externalAccountId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts/{externalAccountId}", requestOptions);
        }

        public virtual StripeExternalAccount Update(string accountId, string externalAccountId, StripeExternalAccountUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts/{externalAccountId}", requestOptions, options);
        }

        public virtual StripeList<StripeExternalAccount> List(string accountId, StripeExternalAccountListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts", requestOptions, listOptions);
        }

        public virtual StripeDeleted Delete(string accountId, string externalAccountId, StripeRequestOptions requestOptions = null)
        {
            return DeleteEntity($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts/{externalAccountId}", requestOptions);
        }



        // Async
        public virtual Task<StripeExternalAccount> CreateAsync(string accountId, StripeExternalAccountCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeExternalAccount> GetAsync(string accountId, string externalAccountId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts/{externalAccountId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeExternalAccount> UpdateAsync(string accountId, string externalAccountId, StripeExternalAccountUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts/{externalAccountId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<StripeExternalAccount>> ListAsync(string accountId, StripeExternalAccountListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<StripeDeleted> DeleteAsync(string accountId, string externalAccountId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteEntityAsync($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts/{externalAccountId}", requestOptions, cancellationToken);
        }
    }
}
