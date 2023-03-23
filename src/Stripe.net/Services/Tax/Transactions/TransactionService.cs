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

        public virtual Transaction CreateFromCalculation(TransactionCreateFromCalculationOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl("create_from_calculation")}", options, requestOptions);
        }

        public virtual Task<Transaction> CreateFromCalculationAsync(TransactionCreateFromCalculationOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl("create_from_calculation")}", options, requestOptions, cancellationToken);
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

        public virtual StripeList<TransactionLineItem> ListLineItems(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TransactionLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/line_items", options, requestOptions);
        }

        public virtual Task<StripeList<TransactionLineItem>> ListLineItemsAsync(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TransactionLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<TransactionLineItem> ListLineItemsAutoPaging(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TransactionLineItem>($"{this.InstanceUrl(id)}/line_items", options, requestOptions);
        }

        public virtual IAsyncEnumerable<TransactionLineItem> ListLineItemsAutoPagingAsync(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TransactionLineItem>($"{this.InstanceUrl(id)}/line_items", options, requestOptions, cancellationToken);
        }
    }
}
