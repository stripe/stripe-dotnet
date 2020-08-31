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

        public override string BasePath => "/v1/customers/{PARENT_ID}/sources";

        public virtual BankAccount Create(string parentId, BankAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(parentId, options, requestOptions);
        }

        public virtual Task<BankAccount> CreateAsync(string parentId, BankAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual BankAccount Delete(string parentId, string id, BankAccountDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteNestedEntity(parentId, id, options, requestOptions);
        }

        public virtual Task<BankAccount> DeleteAsync(string parentId, string id, BankAccountDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public virtual BankAccount Get(string parentId, string id, BankAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(parentId, id, options, requestOptions);
        }

        public virtual Task<BankAccount> GetAsync(string parentId, string id, BankAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<BankAccount> List(string parentId, BankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(parentId, options ?? new BankAccountListOptions(), requestOptions);
        }

        public virtual Task<StripeList<BankAccount>> ListAsync(string parentId, BankAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(parentId, options ?? new BankAccountListOptions(), requestOptions, cancellationToken);
        }

        public virtual IEnumerable<BankAccount> ListAutoPaging(string parentId, BankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(parentId, options ?? new BankAccountListOptions(), requestOptions);
        }

        public virtual IAsyncEnumerable<BankAccount> ListAutoPagingAsync(string parentId, BankAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(parentId, options ?? new BankAccountListOptions(), requestOptions, cancellationToken);
        }

        public virtual BankAccount Update(string parentId, string id, BankAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(parentId, id, options, requestOptions);
        }

        public virtual Task<BankAccount> UpdateAsync(string parentId, string id, BankAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public virtual BankAccount Verify(string parentId, string id, BankAccountVerifyOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(parentId, id)}/verify", options, requestOptions);
        }

        public virtual Task<BankAccount> VerifyAsync(string parentId, string id, BankAccountVerifyOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(parentId, id)}/verify", options, requestOptions, cancellationToken);
        }
    }
}
