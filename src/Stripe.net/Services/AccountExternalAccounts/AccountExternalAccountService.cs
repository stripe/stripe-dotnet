// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountExternalAccountService : ServiceNested<IExternalAccount>,
        INestedCreatable<IExternalAccount, AccountExternalAccountCreateOptions>,
        INestedDeletable<IExternalAccount, AccountExternalAccountDeleteOptions>,
        INestedListable<IExternalAccount, AccountExternalAccountListOptions>,
        INestedRetrievable<IExternalAccount, AccountExternalAccountGetOptions>,
        INestedUpdatable<IExternalAccount, AccountExternalAccountUpdateOptions>
    {
        public AccountExternalAccountService()
        {
        }

        internal AccountExternalAccountService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AccountExternalAccountService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Create an external account for a given account.</p>.
        /// </summary>
        public virtual IExternalAccount Create(string parentId, AccountExternalAccountCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/external_accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>Create an external account for a given account.</p>.
        /// </summary>
        public virtual Task<IExternalAccount> CreateAsync(string parentId, AccountExternalAccountCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/external_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Delete a specified external account for a given account.</p>.
        /// </summary>
        public virtual IExternalAccount Delete(string parentId, string id, AccountExternalAccountDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/external_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Delete a specified external account for a given account.</p>.
        /// </summary>
        public virtual Task<IExternalAccount> DeleteAsync(string parentId, string id, AccountExternalAccountDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/external_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a specified external account for a given account.</p>.
        /// </summary>
        public virtual IExternalAccount Get(string parentId, string id, AccountExternalAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/external_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a specified external account for a given account.</p>.
        /// </summary>
        public virtual Task<IExternalAccount> GetAsync(string parentId, string id, AccountExternalAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/external_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List external accounts for an account.</p>.
        /// </summary>
        public virtual StripeList<IExternalAccount> List(string parentId, AccountExternalAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<IExternalAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/external_accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>List external accounts for an account.</p>.
        /// </summary>
        public virtual Task<StripeList<IExternalAccount>> ListAsync(string parentId, AccountExternalAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<IExternalAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/external_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List external accounts for an account.</p>.
        /// </summary>
        public virtual IEnumerable<IExternalAccount> ListAutoPaging(string parentId, AccountExternalAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<IExternalAccount>($"/v1/accounts/{WebUtility.UrlEncode(parentId)}/external_accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>List external accounts for an account.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<IExternalAccount> ListAutoPagingAsync(string parentId, AccountExternalAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<IExternalAccount>($"/v1/accounts/{WebUtility.UrlEncode(parentId)}/external_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the metadata, account holder name, account holder type of a bank account
        /// belonging to a connected account and optionally sets it as the default for its currency.
        /// Other bank account details are not editable by design.</p>.
        ///
        /// <p>You can only update bank accounts when <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">account.controller.requirement_collection</a>
        /// is <c>application</c>, which includes <a
        /// href="https://stripe.com/connect/custom-accounts">Custom accounts</a>.</p>.
        ///
        /// <p>You can re-enable a disabled bank account by performing an update call without
        /// providing any arguments or changes.</p>.
        /// </summary>
        public virtual IExternalAccount Update(string parentId, string id, AccountExternalAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/external_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the metadata, account holder name, account holder type of a bank account
        /// belonging to a connected account and optionally sets it as the default for its currency.
        /// Other bank account details are not editable by design.</p>.
        ///
        /// <p>You can only update bank accounts when <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">account.controller.requirement_collection</a>
        /// is <c>application</c>, which includes <a
        /// href="https://stripe.com/connect/custom-accounts">Custom accounts</a>.</p>.
        ///
        /// <p>You can re-enable a disabled bank account by performing an update call without
        /// providing any arguments or changes.</p>.
        /// </summary>
        public virtual Task<IExternalAccount> UpdateAsync(string parentId, string id, AccountExternalAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/external_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
