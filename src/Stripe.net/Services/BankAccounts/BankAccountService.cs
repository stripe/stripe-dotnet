namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
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
            : base()
        {
        }

        internal BankAccountService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public BankAccountService(IStripeClient client)
            : base(client)
        {
        }

        public virtual BankAccount Create(string parentId, BankAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<BankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources", options, requestOptions);
        }

        public virtual Task<BankAccount> CreateAsync(string parentId, BankAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources", options, requestOptions, cancellationToken);
        }

        public virtual BankAccount Delete(string parentId, string id, BankAccountDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BankAccount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        public virtual Task<BankAccount> DeleteAsync(string parentId, string id, BankAccountDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BankAccount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        public virtual BankAccount Get(string parentId, string id, BankAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BankAccount>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        public virtual Task<BankAccount> GetAsync(string parentId, string id, BankAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BankAccount>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<BankAccount> List(string parentId, BankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<BankAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources", options ?? new BankAccountListOptions(), requestOptions);
        }

        public virtual Task<StripeList<BankAccount>> ListAsync(string parentId, BankAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<BankAccount>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources", options ?? new BankAccountListOptions(), requestOptions, cancellationToken);
        }

        public virtual IEnumerable<BankAccount> ListAutoPaging(string parentId, BankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<BankAccount>($"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources", options ?? new BankAccountListOptions(), requestOptions);
        }

        public virtual IAsyncEnumerable<BankAccount> ListAutoPagingAsync(string parentId, BankAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<BankAccount>($"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources", options ?? new BankAccountListOptions(), requestOptions, cancellationToken);
        }

        public virtual BankAccount Update(string parentId, string id, BankAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<BankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        public virtual Task<BankAccount> UpdateAsync(string parentId, string id, BankAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        public virtual BankAccount Verify(string parentId, string id, BankAccountVerifyOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}/verify", options, requestOptions);
        }

        public virtual Task<BankAccount> VerifyAsync(string parentId, string id, BankAccountVerifyOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}/verify", options, requestOptions, cancellationToken);
        }
    }
}
