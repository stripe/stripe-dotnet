// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ExternalAccountService : Service,
        ICreatable<IExternalAccount, ExternalAccountCreateOptions>,
        IDeletable<IExternalAccount, ExternalAccountDeleteOptions>,
        IListable<IExternalAccount, ExternalAccountListOptions>,
        IRetrievable<IExternalAccount, ExternalAccountGetOptions>,
        IUpdatable<IExternalAccount, ExternalAccountUpdateOptions>
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
        /// <p>Create an external account for a given connected account.</p>.
        /// </summary>
        public virtual IExternalAccount Create(ExternalAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/external_accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>Create an external account for a given connected account.</p>.
        /// </summary>
        public virtual Task<IExternalAccount> CreateAsync(ExternalAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/external_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Delete a specified external account for a given account.</p>.
        /// </summary>
        public virtual IExternalAccount Delete(string id, ExternalAccountDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/external_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Delete a specified external account for a given account.</p>.
        /// </summary>
        public virtual Task<IExternalAccount> DeleteAsync(string id, ExternalAccountDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/external_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a specified external account for a given account.</p>.
        /// </summary>
        public virtual IExternalAccount Get(string id, ExternalAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(BaseAddress.Api, HttpMethod.Get, $"/v1/external_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a specified external account for a given account.</p>.
        /// </summary>
        public virtual Task<IExternalAccount> GetAsync(string id, ExternalAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(BaseAddress.Api, HttpMethod.Get, $"/v1/external_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List external accounts for an account.</p>.
        /// </summary>
        public virtual StripeList<IExternalAccount> List(ExternalAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<IExternalAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v1/external_accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>List external accounts for an account.</p>.
        /// </summary>
        public virtual Task<StripeList<IExternalAccount>> ListAsync(ExternalAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<IExternalAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v1/external_accounts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List external accounts for an account.</p>.
        /// </summary>
        public virtual IEnumerable<IExternalAccount> ListAutoPaging(ExternalAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<IExternalAccount>($"/v1/external_accounts", options, requestOptions);
        }

        /// <summary>
        /// <p>List external accounts for an account.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<IExternalAccount> ListAutoPagingAsync(ExternalAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<IExternalAccount>($"/v1/external_accounts", options, requestOptions, cancellationToken);
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
        public virtual IExternalAccount Update(string id, ExternalAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/external_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions);
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
        public virtual Task<IExternalAccount> UpdateAsync(string id, ExternalAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/external_accounts/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
