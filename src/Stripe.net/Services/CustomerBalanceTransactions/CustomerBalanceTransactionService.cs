namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerBalanceTransactionService : ServiceNested<CustomerBalanceTransaction>,
        INestedCreatable<CustomerBalanceTransaction, CustomerBalanceTransactionCreateOptions>,
        INestedListable<CustomerBalanceTransaction, CustomerBalanceTransactionListOptions>,
        INestedRetrievable<CustomerBalanceTransaction, CustomerBalanceTransactionGetOptions>,
        INestedUpdatable<CustomerBalanceTransaction, CustomerBalanceTransactionUpdateOptions>
    {
        public CustomerBalanceTransactionService()
            : base(null)
        {
        }

        public CustomerBalanceTransactionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/customers/{PARENT_ID}/balance_transactions";

        public virtual CustomerBalanceTransaction Create(string parentId, CustomerBalanceTransactionCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(parentId, options, requestOptions);
        }

        public virtual Task<CustomerBalanceTransaction> CreateAsync(string parentId, CustomerBalanceTransactionCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual CustomerBalanceTransaction Get(string parentId, string id, CustomerBalanceTransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(parentId, id, options, requestOptions);
        }

        public virtual Task<CustomerBalanceTransaction> GetAsync(string parentId, string id, CustomerBalanceTransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CustomerBalanceTransaction> List(string parentId, CustomerBalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(parentId, options, requestOptions);
        }

        public virtual Task<StripeList<CustomerBalanceTransaction>> ListAsync(string parentId, CustomerBalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CustomerBalanceTransaction> ListAutoPaging(string parentId, CustomerBalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(parentId, options, requestOptions);
        }

        public virtual IAsyncEnumerable<CustomerBalanceTransaction> ListAutoPagingAsync(string parentId, CustomerBalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual CustomerBalanceTransaction Update(string parentId, string id, CustomerBalanceTransactionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(parentId, id, options, requestOptions);
        }

        public virtual Task<CustomerBalanceTransaction> UpdateAsync(string parentId, string id, CustomerBalanceTransactionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }
    }
}
