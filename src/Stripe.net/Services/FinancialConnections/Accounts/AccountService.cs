// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class AccountService : Service,
        IListable<Account, AccountListOptions>,
        IRetrievable<Account, AccountGetOptions>
    {
        private AccountInferredBalanceService inferredBalances;
        private AccountOwnerService owners;

        public AccountService()
        {
        }

        internal AccountService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AccountService(IStripeClient client)
            : base(client)
        {
        }

        public virtual AccountInferredBalanceService InferredBalances => this.inferredBalances ??= new AccountInferredBalanceService(
            this.Requestor);

        public virtual AccountOwnerService Owners => this.owners ??= new AccountOwnerService(
            this.Requestor);

        /// <summary>
        /// <p>Disables your access to a Financial Connections <c>Account</c>. You will no longer be
        /// able to access data associated with the account (e.g. balances, transactions).</p>.
        /// </summary>
        public virtual Account Disconnect(string id, AccountDisconnectOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(BaseAddress.Api, HttpMethod.Post, $"/v1/financial_connections/accounts/{WebUtility.UrlEncode(id)}/disconnect", options, requestOptions);
        }

        /// <summary>
        /// <p>Disables your access to a Financial Connections <c>Account</c>. You will no longer be
        /// able to access data associated with the account (e.g. balances, transactions).</p>.
        /// </summary>
        public virtual Task<Account> DisconnectAsync(string id, AccountDisconnectOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(BaseAddress.Api, HttpMethod.Post, $"/v1/financial_connections/accounts/{WebUtility.UrlEncode(id)}/disconnect", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual Account Get(string id, AccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual Task<Account> GetAsync(string id, AccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Account</c> objects.</p>.
        /// </summary>
        public virtual StripeList<Account> List(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Account>>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Account</c> objects.</p>.
        /// </summary>
        public virtual Task<StripeList<Account>> ListAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Account>>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/accounts", options, requestOptions, cancellationToken);
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
        /// <p>Refreshes the data associated with a Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual Account Refresh(string id, AccountRefreshOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(BaseAddress.Api, HttpMethod.Post, $"/v1/financial_connections/accounts/{WebUtility.UrlEncode(id)}/refresh", options, requestOptions);
        }

        /// <summary>
        /// <p>Refreshes the data associated with a Financial Connections <c>Account</c>.</p>.
        /// </summary>
        public virtual Task<Account> RefreshAsync(string id, AccountRefreshOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(BaseAddress.Api, HttpMethod.Post, $"/v1/financial_connections/accounts/{WebUtility.UrlEncode(id)}/refresh", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Subscribes to periodic refreshes of data associated with a Financial Connections
        /// <c>Account</c>.</p>.
        /// </summary>
        public virtual Account Subscribe(string id, AccountSubscribeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(BaseAddress.Api, HttpMethod.Post, $"/v1/financial_connections/accounts/{WebUtility.UrlEncode(id)}/subscribe", options, requestOptions);
        }

        /// <summary>
        /// <p>Subscribes to periodic refreshes of data associated with a Financial Connections
        /// <c>Account</c>.</p>.
        /// </summary>
        public virtual Task<Account> SubscribeAsync(string id, AccountSubscribeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(BaseAddress.Api, HttpMethod.Post, $"/v1/financial_connections/accounts/{WebUtility.UrlEncode(id)}/subscribe", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Unsubscribes from periodic refreshes of data associated with a Financial Connections
        /// <c>Account</c>.</p>.
        /// </summary>
        public virtual Account Unsubscribe(string id, AccountUnsubscribeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(BaseAddress.Api, HttpMethod.Post, $"/v1/financial_connections/accounts/{WebUtility.UrlEncode(id)}/unsubscribe", options, requestOptions);
        }

        /// <summary>
        /// <p>Unsubscribes from periodic refreshes of data associated with a Financial Connections
        /// <c>Account</c>.</p>.
        /// </summary>
        public virtual Task<Account> UnsubscribeAsync(string id, AccountUnsubscribeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(BaseAddress.Api, HttpMethod.Post, $"/v1/financial_connections/accounts/{WebUtility.UrlEncode(id)}/unsubscribe", options, requestOptions, cancellationToken);
        }
    }
}
