// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountService : Service
    {
        internal AccountService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AccountService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Closes and removes access to the Account and its associated resources.
        /// </summary>
        public virtual Account Close(string id, AccountCloseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(BaseAddress.Api, HttpMethod.Post, $"/v2/accounts/{WebUtility.UrlEncode(id)}/close", options, requestOptions);
        }

        /// <summary>
        /// Closes and removes access to the Account and its associated resources.
        /// </summary>
        public virtual Task<Account> CloseAsync(string id, AccountCloseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(BaseAddress.Api, HttpMethod.Post, $"/v2/accounts/{WebUtility.UrlEncode(id)}/close", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Creates an Account. You can optionally provide information about the associated Legal
        /// Entity, such as name and business type. The Account can also be configured as a
        /// recipient of OutboundPayments by requesting Features on the recipient configuration.
        /// </summary>
        public virtual Account Create(AccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(BaseAddress.Api, HttpMethod.Post, $"/v2/accounts", options, requestOptions);
        }

        /// <summary>
        /// Creates an Account. You can optionally provide information about the associated Legal
        /// Entity, such as name and business type. The Account can also be configured as a
        /// recipient of OutboundPayments by requesting Features on the recipient configuration.
        /// </summary>
        public virtual Task<Account> CreateAsync(AccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(BaseAddress.Api, HttpMethod.Post, $"/v2/accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of an Account.
        /// </summary>
        public virtual Account Get(string id, AccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(BaseAddress.Api, HttpMethod.Get, $"/v2/accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an Account.
        /// </summary>
        public virtual Task<Account> GetAsync(string id, AccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(BaseAddress.Api, HttpMethod.Get, $"/v2/accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of Accounts. Note that the <c>include</c> parameter cannot be passed in
        /// on list requests.
        /// </summary>
        public virtual StripeList<Account> List(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Account>>(BaseAddress.Api, HttpMethod.Get, $"/v2/accounts", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of Accounts. Note that the <c>include</c> parameter cannot be passed in
        /// on list requests.
        /// </summary>
        public virtual Task<StripeList<Account>> ListAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Account>>(BaseAddress.Api, HttpMethod.Get, $"/v2/accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of Accounts. Note that the <c>include</c> parameter cannot be passed in
        /// on list requests.
        /// </summary>
        public virtual IEnumerable<Account> ListAutoPaging(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Account>($"/v2/accounts", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of Accounts. Note that the <c>include</c> parameter cannot be passed in
        /// on list requests.
        /// </summary>
        public virtual IAsyncEnumerable<Account> ListAutoPagingAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Account>($"/v2/accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Updates the details of an Account. You can also optionally provide or update the details
        /// of the associated Legal Entity and recipient configuration.
        /// </summary>
        public virtual Account Update(string id, AccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(BaseAddress.Api, HttpMethod.Post, $"/v2/accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Updates the details of an Account. You can also optionally provide or update the details
        /// of the associated Legal Entity and recipient configuration.
        /// </summary>
        public virtual Task<Account> UpdateAsync(string id, AccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(BaseAddress.Api, HttpMethod.Post, $"/v2/accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
