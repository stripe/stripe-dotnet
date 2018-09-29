namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class AccountService : Service<Account>,
        ICreatable<Account, AccountCreateOptions>,
        IDeletable<Account>,
        IListable<Account, AccountListOptions>,
        IRetrievable<Account>,
        IUpdatable<Account, AccountUpdateOptions>
    {
        public AccountService()
            : base(null)
        {
        }

        public AccountService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandBusinessLogo { get; set; }

        public virtual Account Create(AccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/accounts", requestOptions, options);
        }

        public virtual Task<Account> CreateAsync(AccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/accounts", requestOptions, cancellationToken, options);
        }

        public virtual Account Delete(string accountId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/accounts/{accountId}", requestOptions);
        }

        public virtual Task<Account> DeleteAsync(string accountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/accounts/{accountId}", requestOptions, cancellationToken);
        }

        public virtual Account Get(RequestOptions requestOptions = null)
        {
            return this.Get(string.Empty, requestOptions);
        }

        public virtual Account Get(string accountId, RequestOptions requestOptions = null)
        {
            var path = string.IsNullOrEmpty(accountId) ? $"{Urls.BaseUrl}/account" : $"{Urls.BaseUrl}/accounts/{accountId}";
            return this.GetEntity(path, requestOptions);
        }

        public virtual Task<Account> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetAsync(string.Empty, requestOptions, cancellationToken);
        }

        public virtual Task<Account> GetAsync(string accountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var path = string.IsNullOrEmpty(accountId) ? $"{Urls.BaseUrl}/account" : $"{Urls.BaseUrl}/accounts/{accountId}";
            return this.GetEntityAsync(path, requestOptions, cancellationToken);
        }

        public virtual StripeList<Account> List(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/accounts", requestOptions, options);
        }

        public virtual Task<StripeList<Account>> ListAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/accounts", requestOptions, cancellationToken, options);
        }

        public virtual Account Reject(string accountId, AccountRejectOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/accounts/{accountId}/reject", requestOptions, options);
        }

        public virtual Task<Account> RejectAsync(string accountId, AccountRejectOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/accounts/{accountId}/reject", requestOptions, cancellationToken, options);
        }

        public virtual Account Update(string accountId, AccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/accounts/{accountId}", requestOptions, options);
        }

        public virtual Task<Account> UpdateAsync(string accountId, AccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/accounts/{accountId}", requestOptions, cancellationToken, options);
        }
    }
}
