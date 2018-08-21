namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ExternalAccountService : StripeBasicService<ExternalAccount>
    {
        public ExternalAccountService()
            : base(null)
        {
        }

        public ExternalAccountService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual ExternalAccount Create(string accountId, ExternalAccountCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts", requestOptions, options);
        }

        public virtual ExternalAccount Get(string accountId, string externalAccountId, StripeRequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts/{externalAccountId}", requestOptions);
        }

        public virtual ExternalAccount Update(string accountId, string externalAccountId, ExternalAccountUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts/{externalAccountId}", requestOptions, options);
        }

        public virtual StripeList<ExternalAccount> List(string accountId, ExternalAccountListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts", requestOptions, listOptions);
        }

        public virtual StripeDeleted Delete(string accountId, string externalAccountId, StripeRequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts/{externalAccountId}", requestOptions);
        }

        public virtual Task<ExternalAccount> CreateAsync(string accountId, ExternalAccountCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts", requestOptions, cancellationToken, options);
        }

        public virtual Task<ExternalAccount> GetAsync(string accountId, string externalAccountId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts/{externalAccountId}", requestOptions, cancellationToken);
        }

        public virtual Task<ExternalAccount> UpdateAsync(string accountId, string externalAccountId, ExternalAccountUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts/{externalAccountId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<ExternalAccount>> ListAsync(string accountId, ExternalAccountListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<StripeDeleted> DeleteAsync(string accountId, string externalAccountId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/accounts/{accountId}/external_accounts/{externalAccountId}", requestOptions, cancellationToken);
        }
    }
}
