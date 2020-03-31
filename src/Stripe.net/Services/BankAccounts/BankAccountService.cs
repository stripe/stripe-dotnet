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

        public virtual BankAccount Create(string customerId, BankAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(customerId, options, requestOptions);
        }

        public virtual Task<BankAccount> CreateAsync(string customerId, BankAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(customerId, options, requestOptions, cancellationToken);
        }

        public virtual BankAccount Delete(string customerId, string bankAccountId, BankAccountDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.DeleteNestedEntity(customerId, bankAccountId, options, requestOptions);
        }

        public virtual Task<BankAccount> DeleteAsync(string customerId, string bankAccountId, BankAccountDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteNestedEntityAsync(customerId, bankAccountId, options, requestOptions, cancellationToken);
        }

        public virtual BankAccount Get(string customerId, string bankAccountId, BankAccountGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(customerId, bankAccountId, options, requestOptions);
        }

        public virtual Task<BankAccount> GetAsync(string customerId, string bankAccountId, BankAccountGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(customerId, bankAccountId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<BankAccount> List(string customerId, BankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(customerId, options ?? new BankAccountListOptions(), requestOptions);
        }

        public virtual Task<StripeList<BankAccount>> ListAsync(string customerId, BankAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(customerId, options ?? new BankAccountListOptions(), requestOptions, cancellationToken);
        }

        public virtual IEnumerable<BankAccount> ListAutoPaging(string customerId, BankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(customerId, options ?? new BankAccountListOptions(), requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<BankAccount> ListAutoPagingAsync(string customerId, BankAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(customerId, options ?? new BankAccountListOptions(), requestOptions, cancellationToken);
        }
#endif

        public virtual BankAccount Update(string customerId, string bankAccountId, BankAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(customerId, bankAccountId, options, requestOptions);
        }

        public virtual Task<BankAccount> UpdateAsync(string customerId, string bankAccountId, BankAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateNestedEntityAsync(customerId, bankAccountId, options, requestOptions, cancellationToken);
        }

        public virtual BankAccount Verify(string customerId, string bankAccountId, BankAccountVerifyOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(customerId, bankAccountId)}/verify", options, requestOptions);
        }

        public virtual Task<BankAccount> VerifyAsync(string customerId, string bankAccountId, BankAccountVerifyOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(customerId, bankAccountId)}/verify", options, requestOptions, cancellationToken);
        }
    }
}
