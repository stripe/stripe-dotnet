namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

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

        public override string BasePath => "/v1/accounts";

        public bool ExpandBusinessLogo { get; set; }

        public virtual Account Create(AccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Account> CreateAsync(AccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Account Delete(string accountId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(accountId, null, requestOptions);
        }

        public virtual Task<Account> DeleteAsync(string accountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(accountId, null, requestOptions, cancellationToken);
        }

        public virtual Account Get(string accountId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(accountId, null, requestOptions);
        }

        public virtual Task<Account> GetAsync(string accountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(accountId, null, requestOptions, cancellationToken);
        }

        public virtual Account GetSelf(RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Get, "/v1/account", null, requestOptions);
        }

        public virtual Task<Account> GetSelfAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Get, "/v1/account", null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Account> List(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Account>> ListAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Account> ListAutoPaging(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Account Reject(string accountId, AccountRejectOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(accountId)}/reject", options, requestOptions);
        }

        public virtual Task<Account> RejectAsync(string accountId, AccountRejectOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(accountId)}/reject", options, requestOptions, cancellationToken);
        }

        public virtual Account Update(string accountId, AccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(accountId, options, requestOptions);
        }

        public virtual Task<Account> UpdateAsync(string accountId, AccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(accountId, options, requestOptions, cancellationToken);
        }
    }
}
