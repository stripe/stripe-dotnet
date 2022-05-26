// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountService : Service<Account>,
        IListable<Account, AccountListOptions>,
        IRetrievable<Account, AccountGetOptions>
    {
        public AccountService()
            : base(null)
        {
        }

        public AccountService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/financial_connections/accounts";

        public virtual Account Disconnect(string id, AccountDisconnectOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/disconnect", options, requestOptions);
        }

        public virtual Task<Account> DisconnectAsync(string id, AccountDisconnectOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/disconnect", options, requestOptions, cancellationToken);
        }

        public virtual Account Get(string id, AccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Account> GetAsync(string id, AccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
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

        public virtual IAsyncEnumerable<Account> ListAutoPagingAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual StripeList<AccountOwner> ListOwners(string id, AccountListOwnersOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<AccountOwner>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/owners", options, requestOptions);
        }

        public virtual Task<StripeList<AccountOwner>> ListOwnersAsync(string id, AccountListOwnersOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<AccountOwner>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/owners", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<AccountOwner> ListOwnersAutoPaging(string id, AccountListOwnersOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<AccountOwner>($"{this.InstanceUrl(id)}/owners", options, requestOptions);
        }

        public virtual IAsyncEnumerable<AccountOwner> ListOwnersAutoPagingAsync(string id, AccountListOwnersOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<AccountOwner>($"{this.InstanceUrl(id)}/owners", options, requestOptions, cancellationToken);
        }

        public virtual Account Refresh(string id, AccountRefreshOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/refresh", options, requestOptions);
        }

        public virtual Task<Account> RefreshAsync(string id, AccountRefreshOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/refresh", options, requestOptions, cancellationToken);
        }
    }
}
