// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountService : Service<Account>,
        IListable<Account, AccountListOptions>,
        IRetrievable<Account, AccountGetOptions>
    {
        public AccountService()
        {
        }

        public AccountService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/financial_connections/accounts";

        /// <summary>
        /// <p>Disables your access to a Financial Connections <c>Account</c>. You will no longer be
        /// able to access data associated with the account (e.g. balances, transactions).</p>.
        /// </summary>
        public virtual Account Disconnect(string id, AccountDisconnectOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Post, $"/v1/financial_connections/accounts/{id}/disconnect", options, requestOptions);
        }

        /// <summary>
        /// <p>Disables your access to a Financial Connections <c>Account</c>. You will no longer be
        /// able to access data associated with the account (e.g. balances, transactions).</p>.
        /// </summary>
        public virtual Task<Account> DisconnectAsync(string id, AccountDisconnectOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Post, $"/v1/financial_connections/accounts/{id}/disconnect", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual Account Get(string id, AccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Get, $"/v1/financial_connections/accounts/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual Task<Account> GetAsync(string id, AccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Get, $"/v1/financial_connections/accounts/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Account</c> objects.</p>.
        /// </summary>
        public virtual StripeList<Account> List(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Account>>(HttpMethod.Get, $"/v1/financial_connections/accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Account</c> objects.</p>.
        /// </summary>
        public virtual Task<StripeList<Account>> ListAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Account>>(HttpMethod.Get, $"/v1/financial_connections/accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Account</c> objects.</p>.
        /// </summary>
        public virtual IEnumerable<Account> ListAutoPaging(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Account>($"/v1/financial_connections/accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Account</c> objects.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Account> ListAutoPagingAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Account>($"/v1/financial_connections/accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all owners for a given <c>Account</c></p>.
        /// </summary>
        public virtual StripeList<AccountOwner> ListOwners(string id, AccountListOwnersOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<AccountOwner>>(HttpMethod.Get, $"/v1/financial_connections/accounts/{id}/owners", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all owners for a given <c>Account</c></p>.
        /// </summary>
        public virtual Task<StripeList<AccountOwner>> ListOwnersAsync(string id, AccountListOwnersOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<AccountOwner>>(HttpMethod.Get, $"/v1/financial_connections/accounts/{id}/owners", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all owners for a given <c>Account</c></p>.
        /// </summary>
        public virtual IEnumerable<AccountOwner> ListOwnersAutoPaging(string id, AccountListOwnersOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<AccountOwner>($"/v1/financial_connections/accounts/{id}/owners", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all owners for a given <c>Account</c></p>.
        /// </summary>
        public virtual IAsyncEnumerable<AccountOwner> ListOwnersAutoPagingAsync(string id, AccountListOwnersOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<AccountOwner>($"/v1/financial_connections/accounts/{id}/owners", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Refreshes the data associated with a Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual Account Refresh(string id, AccountRefreshOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Post, $"/v1/financial_connections/accounts/{id}/refresh", options, requestOptions);
        }

        /// <summary>
        /// <p>Refreshes the data associated with a Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual Task<Account> RefreshAsync(string id, AccountRefreshOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Post, $"/v1/financial_connections/accounts/{id}/refresh", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Subscribes to periodic refreshes of data associated with a Financial Connections
        /// <c>Account</c>.</p>.
        /// </summary>
        public virtual Account Subscribe(string id, AccountSubscribeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Post, $"/v1/financial_connections/accounts/{id}/subscribe", options, requestOptions);
        }

        /// <summary>
        /// <p>Subscribes to periodic refreshes of data associated with a Financial Connections
        /// <c>Account</c>.</p>.
        /// </summary>
        public virtual Task<Account> SubscribeAsync(string id, AccountSubscribeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Post, $"/v1/financial_connections/accounts/{id}/subscribe", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Unsubscribes from periodic refreshes of data associated with a Financial Connections
        /// <c>Account</c>.</p>.
        /// </summary>
        public virtual Account Unsubscribe(string id, AccountUnsubscribeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(HttpMethod.Post, $"/v1/financial_connections/accounts/{id}/unsubscribe", options, requestOptions);
        }

        /// <summary>
        /// <p>Unsubscribes from periodic refreshes of data associated with a Financial Connections
        /// <c>Account</c>.</p>.
        /// </summary>
        public virtual Task<Account> UnsubscribeAsync(string id, AccountUnsubscribeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(HttpMethod.Post, $"/v1/financial_connections/accounts/{id}/unsubscribe", options, requestOptions, cancellationToken);
        }
    }
}
