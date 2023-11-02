// File generated from our OpenAPI spec
namespace Stripe
{
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
            return this.Request<Account>(HttpMethod.Post, $"/v1/accounts", options, requestOptions);
        }

        public virtual Task<Account> CreateAsync(AccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Post, $"/v1/accounts", options, requestOptions, cancellationToken);
        }

        public virtual Account Delete(string id, AccountDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Delete, $"/v1/accounts/{id}", options, requestOptions);
        }

        public virtual Task<Account> DeleteAsync(string id, AccountDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Delete, $"/v1/accounts/{id}", options, requestOptions, cancellationToken);
        }

        public virtual Account Get(string id, AccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Get, $"/v1/accounts/{id}", options, requestOptions);
        }

        public virtual Task<Account> GetAsync(string id, AccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Get, $"/v1/accounts/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Account> List(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Account>>(HttpMethod.Get, $"/v1/accounts", options, requestOptions);
        }

        public virtual Task<StripeList<Account>> ListAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Account>>(HttpMethod.Get, $"/v1/accounts", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Account> ListAutoPaging(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Account>($"/v1/accounts", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Account> ListAutoPagingAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Account>($"/v1/accounts", options, requestOptions, cancellationToken);
        }

        public virtual Account Reject(string id, AccountRejectOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Post, $"/v1/accounts/{id}/reject", options, requestOptions);
        }

        public virtual Task<Account> RejectAsync(string id, AccountRejectOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Post, $"/v1/accounts/{id}/reject", options, requestOptions, cancellationToken);
        }

        public virtual Account Update(string id, AccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Post, $"/v1/accounts/{id}", options, requestOptions);
        }

        public virtual Task<Account> UpdateAsync(string id, AccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Post, $"/v1/accounts/{id}", options, requestOptions, cancellationToken);
        }

        public virtual Account GetSelf(RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Get, "/v1/account", null, requestOptions);
        }

        public virtual Task<Account> GetSelfAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Get, "/v1/account", null, requestOptions, cancellationToken);
        }
    }
}
