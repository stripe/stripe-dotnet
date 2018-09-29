namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class TransactionService : Service<Transaction>,
        IListable<Transaction, TransactionListOptions>,
        IRetrievable<Transaction>,
        IUpdatable<Transaction, TransactionUpdateOptions>
    {
        private static string classUrl = Urls.BaseUrl + "/issuing/transactions";

        public TransactionService()
            : base(null)
        {
        }

        public TransactionService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Transaction Get(string transactionId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{classUrl}/{transactionId}", requestOptions);
        }

        public virtual StripeList<Transaction> List(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{classUrl}", requestOptions, options);
        }

        public virtual Transaction Update(string transactionId, TransactionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}/{transactionId}", requestOptions, options);
        }

        public virtual Task<Transaction> GetAsync(string transactionId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{classUrl}/{transactionId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<Transaction>> ListAsync(TransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual Task<Transaction> UpdateAsync(string transactionId, TransactionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}/{transactionId}", requestOptions, cancellationToken, options);
        }
    }
}
