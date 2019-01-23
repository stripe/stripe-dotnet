namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransactionService : Service<Transaction>,
        IListable<Transaction, TransactionListOptions>,
        IRetrievable<Transaction>,
        IUpdatable<Transaction, TransactionUpdateOptions>
    {
        public TransactionService()
            : base(null)
        {
        }

        public TransactionService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/issuing/transactions";

        public virtual Transaction Get(string transactionId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(transactionId, null, requestOptions);
        }

        public virtual Task<Transaction> GetAsync(string transactionId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(transactionId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Transaction> List(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Transaction>> ListAsync(TransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Transaction> ListAutoPaging(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Transaction Update(string transactionId, TransactionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(transactionId, options, requestOptions);
        }

        public virtual Task<Transaction> UpdateAsync(string transactionId, TransactionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(transactionId, options, requestOptions, cancellationToken);
        }
    }
}
