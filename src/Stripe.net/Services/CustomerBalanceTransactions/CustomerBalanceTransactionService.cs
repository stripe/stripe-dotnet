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

        public virtual CustomerBalanceTransaction Create(string customerId, CustomerBalanceTransactionCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(customerId, options, requestOptions);
        }

        public virtual Task<CustomerBalanceTransaction> CreateAsync(string customerId, CustomerBalanceTransactionCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(customerId, options, requestOptions, cancellationToken);
        }

        public virtual CustomerBalanceTransaction Get(string customerId, string transactionId, CustomerBalanceTransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(customerId, transactionId, options, requestOptions);
        }

        public virtual Task<CustomerBalanceTransaction> GetAsync(string customerId, string transactionId, CustomerBalanceTransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(customerId, transactionId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CustomerBalanceTransaction> List(string customerId, CustomerBalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(customerId, options, requestOptions);
        }

        public virtual Task<StripeList<CustomerBalanceTransaction>> ListAsync(string customerId, CustomerBalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(customerId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CustomerBalanceTransaction> ListAutoPaging(string customerId, CustomerBalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(customerId, options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<CustomerBalanceTransaction> ListAutoPagingAsync(string customerId, CustomerBalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(customerId, options, requestOptions, cancellationToken);
        }
#endif

        public virtual CustomerBalanceTransaction Update(string customerId, string transactionId, CustomerBalanceTransactionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(customerId, transactionId, options, requestOptions);
        }

        public virtual Task<CustomerBalanceTransaction> UpdateAsync(string customerId, string transactionId, CustomerBalanceTransactionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateNestedEntityAsync(customerId, transactionId, options, requestOptions, cancellationToken);
        }
    }
}
