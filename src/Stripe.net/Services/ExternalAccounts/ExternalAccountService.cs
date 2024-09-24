namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    [Obsolete("Use AccountExternalAccountService instead.")]
    public class ExternalAccountService : ServiceNested<IExternalAccount>,
        INestedCreatable<IExternalAccount, ExternalAccountCreateOptions>,
        INestedDeletable<IExternalAccount, ExternalAccountDeleteOptions>,
        INestedListable<IExternalAccount, ExternalAccountListOptions>,
        INestedRetrievable<IExternalAccount, ExternalAccountGetOptions>,
        INestedUpdatable<IExternalAccount, ExternalAccountUpdateOptions>
    {
        public ExternalAccountService()
        {
        }

        internal ExternalAccountService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ExternalAccountService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Create an external account for a given account.</p>.
        /// </summary>
        public virtual IExternalAccount Create(string parentId, ExternalAccountCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{parentId}/external_accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>Create an external account for a given account.</p>.
        /// </summary>
        public virtual Task<IExternalAccount> CreateAsync(string parentId, ExternalAccountCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{parentId}/external_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Delete a specified external account for a given account.</p>.
        /// </summary>
        public virtual IExternalAccount Delete(string parentId, string id, ExternalAccountDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/accounts/{parentId}/external_accounts/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Delete a specified external account for a given account.</p>.
        /// </summary>
        public virtual Task<IExternalAccount> DeleteAsync(string parentId, string id, ExternalAccountDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/accounts/{parentId}/external_accounts/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a specified external account for a given account.</p>.
        /// </summary>
        public virtual IExternalAccount Get(string parentId, string id, ExternalAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{parentId}/external_accounts/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a specified external account for a given account.</p>.
        /// </summary>
        public virtual Task<IExternalAccount> GetAsync(string parentId, string id, ExternalAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{parentId}/external_accounts/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List external accounts for an account.</p>.
        /// </summary>
        public virtual StripeList<IExternalAccount> List(string parentId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<IExternalAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{parentId}/external_accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>List external accounts for an account.</p>.
        /// </summary>
        public virtual Task<StripeList<IExternalAccount>> ListAsync(string parentId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<IExternalAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{parentId}/external_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List external accounts for an account.</p>.
        /// </summary>
        public virtual IEnumerable<IExternalAccount> ListAutoPaging(string parentId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<IExternalAccount>($"/v1/accounts/{parentId}/external_accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>List external accounts for an account.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<IExternalAccount> ListAutoPagingAsync(string parentId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<IExternalAccount>($"/v1/accounts/{parentId}/external_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the metadata, account holder name, account holder type of a bank account
        /// belonging to a <a href="https://stripe.com/docs/connect/custom-accounts">Custom
        /// account</a>, and optionally sets it as the default for its currency. Other bank account
        /// details are not editable by design.</p>.
        ///
        /// <p>You can re-enable a disabled bank account by performing an update call without
        /// providing any arguments or changes.</p>.
        /// </summary>
        public virtual IExternalAccount Update(string parentId, string id, ExternalAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{parentId}/external_accounts/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the metadata, account holder name, account holder type of a bank account
        /// belonging to a <a href="https://stripe.com/docs/connect/custom-accounts">Custom
        /// account</a>, and optionally sets it as the default for its currency. Other bank account
        /// details are not editable by design.</p>.
        ///
        /// <p>You can re-enable a disabled bank account by performing an update call without
        /// providing any arguments or changes.</p>.
        /// </summary>
        public virtual Task<IExternalAccount> UpdateAsync(string parentId, string id, ExternalAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/accounts/{parentId}/external_accounts/{id}", options, requestOptions, cancellationToken);
        }
    }
}
