// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountService : Service
    {
        private V2.Core.Accounts.PersonService persons;

        internal AccountService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AccountService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Core.Accounts.PersonService Persons => this.persons ??= new V2.Core.Accounts.PersonService(
            this.Requestor);

        /// <summary>
        /// Removes access to the Account and its associated resources.
        /// </summary>
        public virtual Account Close(string id, AccountCloseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/accounts/{WebUtility.UrlEncode(id)}/close", options, requestOptions);
        }

        /// <summary>
        /// Removes access to the Account and its associated resources.
        /// </summary>
        public virtual Task<Account> CloseAsync(string id, AccountCloseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/accounts/{WebUtility.UrlEncode(id)}/close", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// An Account is a representation of a company, individual or other entity that a user
        /// interacts with. Accounts contain identifying information about the entity, and
        /// configurations that store the features an account has access to. An account can be
        /// configured as any or all of the following configurations: Customer, Merchant and/or
        /// Recipient.
        /// </summary>
        public virtual Account Create(AccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/accounts", options, requestOptions);
        }

        /// <summary>
        /// An Account is a representation of a company, individual or other entity that a user
        /// interacts with. Accounts contain identifying information about the entity, and
        /// configurations that store the features an account has access to. An account can be
        /// configured as any or all of the following configurations: Customer, Merchant and/or
        /// Recipient.
        /// </summary>
        public virtual Task<Account> CreateAsync(AccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of an Account.
        /// </summary>
        public virtual Account Get(string id, AccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an Account.
        /// </summary>
        public virtual Task<Account> GetAsync(string id, AccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of Accounts.
        /// </summary>
        public virtual V2.StripeList<Account> List(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Account>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/accounts", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of Accounts.
        /// </summary>
        public virtual Task<V2.StripeList<Account>> ListAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Account>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of Accounts.
        /// </summary>
        public virtual IEnumerable<Account> ListAutoPaging(AccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Account>($"/v2/core/accounts", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of Accounts.
        /// </summary>
        public virtual IAsyncEnumerable<Account> ListAutoPagingAsync(AccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Account>($"/v2/core/accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Updates the details of an Account.
        /// </summary>
        public virtual Account Update(string id, AccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Account>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Updates the details of an Account.
        /// </summary>
        public virtual Task<Account> UpdateAsync(string id, AccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Account>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
