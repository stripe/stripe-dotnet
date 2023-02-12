// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransactionService : Service<Transaction>,
        ICreatable<Transaction, TransactionCreateOptions>,
        IRetrievable<Transaction, TransactionGetOptions>
    {
        public TransactionService()
            : base(null)
        {
        }

        public TransactionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/tax/transactions";

        public virtual Transaction Create(TransactionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Transaction> CreateAsync(TransactionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Transaction CreateReversal(TransactionCreateReversalOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl("create_reversal")}", options, requestOptions);
        }

        public virtual Task<Transaction> CreateReversalAsync(TransactionCreateReversalOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl("create_reversal")}", options, requestOptions, cancellationToken);
        }

        public virtual Transaction Get(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Transaction> GetAsync(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<LineItem> ListLineItems(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/line_items", options, requestOptions);
        }

        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"{this.InstanceUrl(id)}/line_items", options, requestOptions);
        }

        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"{this.InstanceUrl(id)}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Transaction> ListTransactions(TransactionListTransactionsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Transaction>>(HttpMethod.Get, $"{this.InstanceUrl("undefined")}", options, requestOptions);
        }

        public virtual Task<StripeList<Transaction>> ListTransactionsAsync(TransactionListTransactionsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Transaction>>(HttpMethod.Get, $"{this.InstanceUrl("undefined")}", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Transaction> ListTransactionsAutoPaging(TransactionListTransactionsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Transaction>($"{this.InstanceUrl("undefined")}", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Transaction> ListTransactionsAutoPagingAsync(TransactionListTransactionsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Transaction>($"{this.InstanceUrl("undefined")}", options, requestOptions, cancellationToken);
        }
    }
}
