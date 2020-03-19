namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountService : Service<Account>,
        ICreatable<Account, AccountCreateOptions>,
        IDeletable<Account, AccountDeleteOptions>,
        IListable<Account, AccountListOptions>,
        IRetrievable<Account, AccountGetOptions>,
        IUpdatable<Account, AccountUpdateOptions>
    {
        public AccountService()
            : base(null)
        {
        }

        public AccountService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/accounts";

        public virtual Account Create(AccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Account> CreateAsync(AccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Account Delete(string accountId, AccountDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(accountId, options, requestOptions);
        }

        public virtual Task<Account> DeleteAsync(string accountId, AccountDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(accountId, options, requestOptions, cancellationToken);
        }

        public virtual Account Get(string accountId, AccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(accountId, options, requestOptions);
        }

        public virtual Task<Account> GetAsync(string accountId, AccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(accountId, options, requestOptions, cancellationToken);
        }

        public virtual Account GetSelf(RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Get, "/v1/account", null, requestOptions);
        }

        public virtual Task<Account> GetSelfAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Get, "/v1/account", null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Account> List(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Account>> ListAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Account> ListAutoPaging(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Account> ListAutoPagingAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual Account Reject(string accountId, AccountRejectOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(accountId)}/reject", options, requestOptions);
        }

        public virtual Task<Account> RejectAsync(string accountId, AccountRejectOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(accountId)}/reject", options, requestOptions, cancellationToken);
        }

        public virtual Account Update(string accountId, AccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(accountId, options, requestOptions);
        }

        public virtual Task<Account> UpdateAsync(string accountId, AccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(accountId, options, requestOptions, cancellationToken);
        }
    }
}
