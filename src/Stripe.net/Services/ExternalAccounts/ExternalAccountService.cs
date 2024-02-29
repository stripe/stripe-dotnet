// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ExternalAccountService : ServiceNested<IExternalAccount>,
        INestedCreatable<IExternalAccount, ExternalAccountCreateOptions>,
        INestedDeletable<IExternalAccount, ExternalAccountDeleteOptions>,
        INestedListable<IExternalAccount, ExternalAccountListOptions>,
        INestedRetrievable<IExternalAccount, ExternalAccountGetOptions>,
        INestedUpdatable<IExternalAccount, ExternalAccountUpdateOptions>
    {
        public ExternalAccountService()
            : base(null)
        {
        }

        public ExternalAccountService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/accounts/{PARENT_ID}/external_accounts";

        public virtual IExternalAccount Create(string parentId, ExternalAccountCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(HttpMethod.Post, $"/v1/accounts/{parentId}/external_accounts", options, requestOptions);
        }

        public virtual Task<IExternalAccount> CreateAsync(string parentId, ExternalAccountCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(HttpMethod.Post, $"/v1/accounts/{parentId}/external_accounts", options, requestOptions, cancellationToken);
        }

        public virtual IExternalAccount Delete(string parentId, string id, ExternalAccountDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(HttpMethod.Delete, $"/v1/accounts/{parentId}/external_accounts/{id}", options, requestOptions);
        }

        public virtual Task<IExternalAccount> DeleteAsync(string parentId, string id, ExternalAccountDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(HttpMethod.Delete, $"/v1/accounts/{parentId}/external_accounts/{id}", options, requestOptions, cancellationToken);
        }

        public virtual IExternalAccount Get(string parentId, string id, ExternalAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(HttpMethod.Get, $"/v1/accounts/{parentId}/external_accounts/{id}", options, requestOptions);
        }

        public virtual Task<IExternalAccount> GetAsync(string parentId, string id, ExternalAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(HttpMethod.Get, $"/v1/accounts/{parentId}/external_accounts/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<IExternalAccount> List(string parentId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<IExternalAccount>>(HttpMethod.Get, $"/v1/accounts/{parentId}/external_accounts", options, requestOptions);
        }

        public virtual Task<StripeList<IExternalAccount>> ListAsync(string parentId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<IExternalAccount>>(HttpMethod.Get, $"/v1/accounts/{parentId}/external_accounts", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<IExternalAccount> ListAutoPaging(string parentId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<IExternalAccount>($"/v1/accounts/{parentId}/external_accounts", options, requestOptions);
        }

        public virtual IAsyncEnumerable<IExternalAccount> ListAutoPagingAsync(string parentId, ExternalAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<IExternalAccount>($"/v1/accounts/{parentId}/external_accounts", options, requestOptions, cancellationToken);
        }

        public virtual IExternalAccount Update(string parentId, string id, ExternalAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<IExternalAccount>(HttpMethod.Post, $"/v1/accounts/{parentId}/external_accounts/{id}", options, requestOptions);
        }

        public virtual Task<IExternalAccount> UpdateAsync(string parentId, string id, ExternalAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IExternalAccount>(HttpMethod.Post, $"/v1/accounts/{parentId}/external_accounts/{id}", options, requestOptions, cancellationToken);
        }
    }
}
