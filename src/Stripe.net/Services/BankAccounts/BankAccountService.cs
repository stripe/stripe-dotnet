namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class BankAccountService : ServiceNested<BankAccount>,
        INestedCreatable<BankAccount, BankAccountCreateOptions>,
        INestedDeletable<BankAccount, BankAccountDeleteOptions>,
        INestedListable<BankAccount, BankAccountListOptions>,
        INestedRetrievable<BankAccount, BankAccountGetOptions>,
        INestedUpdatable<BankAccount, BankAccountUpdateOptions>
    {
        public BankAccountService()
            : base(null)
        {
        }

        public BankAccountService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/customers/{PARENT_ID}/sources";

        public virtual BankAccount Create(string parentId, BankAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<BankAccount>(HttpMethod.Post, $"/v1/customers/{parentId}/sources", options, requestOptions);
        }

        public virtual Task<BankAccount> CreateAsync(string parentId, BankAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BankAccount>(HttpMethod.Post, $"/v1/customers/{parentId}/sources", options, requestOptions, cancellationToken);
        }

        public virtual BankAccount Delete(string parentId, string id, BankAccountDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BankAccount>(HttpMethod.Delete, $"/v1/customers/{parentId}/sources/{id}", options, requestOptions);
        }

        public virtual Task<BankAccount> DeleteAsync(string parentId, string id, BankAccountDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BankAccount>(HttpMethod.Delete, $"/v1/customers/{parentId}/sources/{id}", options, requestOptions, cancellationToken);
        }

        public virtual BankAccount Get(string parentId, string id, BankAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BankAccount>(HttpMethod.Get, $"/v1/customers/{parentId}/sources/{id}", options, requestOptions);
        }

        public virtual Task<BankAccount> GetAsync(string parentId, string id, BankAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BankAccount>(HttpMethod.Get, $"/v1/customers/{parentId}/sources/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<BankAccount> List(string parentId, BankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<BankAccount>>(HttpMethod.Get, $"/v1/customers/{parentId}/sources", options ?? new BankAccountListOptions(), requestOptions);
        }

        public virtual Task<StripeList<BankAccount>> ListAsync(string parentId, BankAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<BankAccount>>(HttpMethod.Get, $"/v1/customers/{parentId}/sources", options ?? new BankAccountListOptions(), requestOptions, cancellationToken);
        }

        public virtual IEnumerable<BankAccount> ListAutoPaging(string parentId, BankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<BankAccount>($"/v1/customers/{parentId}/sources", options ?? new BankAccountListOptions(), requestOptions);
        }

        public virtual IAsyncEnumerable<BankAccount> ListAutoPagingAsync(string parentId, BankAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<BankAccount>($"/v1/customers/{parentId}/sources", options ?? new BankAccountListOptions(), requestOptions, cancellationToken);
        }

        public virtual BankAccount Update(string parentId, string id, BankAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<BankAccount>(HttpMethod.Post, $"/v1/customers/{parentId}/sources/{id}", options, requestOptions);
        }

        public virtual Task<BankAccount> UpdateAsync(string parentId, string id, BankAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BankAccount>(HttpMethod.Post, $"/v1/customers/{parentId}/sources/{id}", options, requestOptions, cancellationToken);
        }

        public virtual BankAccount Verify(string parentId, string id, BankAccountVerifyOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"/v1/customers/{parentId}/sources/{id}/verify", options, requestOptions);
        }

        public virtual Task<BankAccount> VerifyAsync(string parentId, string id, BankAccountVerifyOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"/v1/customers/{parentId}/sources/{id}/verify", options, requestOptions, cancellationToken);
        }
    }
}
