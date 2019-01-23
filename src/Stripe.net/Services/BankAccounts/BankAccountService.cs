namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class BankAccountService : ServiceNested<BankAccount>,
        INestedCreatable<BankAccount, BankAccountCreateOptions>,
        INestedDeletable<BankAccount>,
        INestedListable<BankAccount, BankAccountListOptions>,
        INestedRetrievable<BankAccount>,
        INestedUpdatable<BankAccount, BankAccountUpdateOptions>
    {
        public BankAccountService()
            : base(null)
        {
        }

        public BankAccountService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/customers/{PARENT_ID}/sources";

        public bool ExpandCustomer { get; set; }

        public virtual BankAccount Create(string customerId, BankAccountCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(customerId, options, requestOptions);
        }

        public virtual Task<BankAccount> CreateAsync(string customerId, BankAccountCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateNestedEntityAsync(customerId, options, requestOptions, cancellationToken);
        }

        public virtual BankAccount Delete(string customerId, string bankAccountId, RequestOptions requestOptions = null)
        {
            return this.DeleteNestedEntity(customerId, bankAccountId, null, requestOptions);
        }

        public virtual Task<BankAccount> DeleteAsync(string customerId, string bankAccountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteNestedEntityAsync(customerId, bankAccountId, null, requestOptions, cancellationToken);
        }

        public virtual BankAccount Get(string customerId, string bankAccountId, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(customerId, bankAccountId, null, requestOptions);
        }

        public virtual Task<BankAccount> GetAsync(string customerId, string bankAccountId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetNestedEntityAsync(customerId, bankAccountId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<BankAccount> List(string customerId, BankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(customerId, options, requestOptions);
        }

        public virtual Task<StripeList<BankAccount>> ListAsync(string customerId, BankAccountListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListNestedEntitiesAsync(customerId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<BankAccount> ListAutoPaging(string customerId, BankAccountListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(customerId, options, requestOptions);
        }

        public virtual BankAccount Update(string customerId, string bankAccountId, BankAccountUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(customerId, bankAccountId, options, requestOptions);
        }

        public virtual Task<BankAccount> UpdateAsync(string customerId, string bankAccountId, BankAccountUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateNestedEntityAsync(customerId, bankAccountId, options, requestOptions, cancellationToken);
        }

        public virtual BankAccount Verify(string customerId, string bankAccountId, BankAccountVerifyOptions options, RequestOptions requestOptions = null)
        {
            return this.PostRequest<BankAccount>($"{this.InstanceUrl(customerId, bankAccountId)}/verify", options, requestOptions);
        }

        public virtual Task<BankAccount> VerifyAsync(string customerId, string bankAccountId, BankAccountVerifyOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostRequestAsync<BankAccount>($"{this.InstanceUrl(customerId, bankAccountId)}/verify", options, requestOptions, cancellationToken);
        }
    }
}
