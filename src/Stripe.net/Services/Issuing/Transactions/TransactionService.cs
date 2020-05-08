namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class TransactionService : Service<Transaction>,
        IListable<Transaction, TransactionListOptions>,
        IRetrievable<Transaction, TransactionGetOptions>,
        IUpdatable<Transaction, TransactionUpdateOptions>
    {
        public TransactionService()
            : base(null)
        {
        }

        public TransactionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/issuing/transactions";

        public virtual Transaction Get(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Transaction> GetAsync(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Transaction> List(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Transaction>> ListAsync(TransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Transaction> ListAutoPaging(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Transaction Update(string id, TransactionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Transaction> UpdateAsync(string id, TransactionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
