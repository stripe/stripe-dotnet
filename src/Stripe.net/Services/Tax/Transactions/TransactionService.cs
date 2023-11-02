// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransactionService : Service<Transaction>,
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

        public virtual Transaction CreateFromCalculation(TransactionCreateFromCalculationOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(HttpMethod.Post, $"/v1/tax/transactions/create_from_calculation", options, requestOptions);
        }

        public virtual Task<Transaction> CreateFromCalculationAsync(TransactionCreateFromCalculationOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(HttpMethod.Post, $"/v1/tax/transactions/create_from_calculation", options, requestOptions, cancellationToken);
        }

        public virtual Transaction CreateReversal(TransactionCreateReversalOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(HttpMethod.Post, $"/v1/tax/transactions/create_reversal", options, requestOptions);
        }

        public virtual Task<Transaction> CreateReversalAsync(TransactionCreateReversalOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(HttpMethod.Post, $"/v1/tax/transactions/create_reversal", options, requestOptions, cancellationToken);
        }

        public virtual Transaction Get(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(HttpMethod.Get, $"/v1/tax/transactions/{id}", options, requestOptions);
        }

        public virtual Task<Transaction> GetAsync(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(HttpMethod.Get, $"/v1/tax/transactions/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<TransactionLineItem> ListLineItems(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TransactionLineItem>>(HttpMethod.Get, $"/v1/tax/transactions/{id}/line_items", options, requestOptions);
        }

        public virtual Task<StripeList<TransactionLineItem>> ListLineItemsAsync(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TransactionLineItem>>(HttpMethod.Get, $"/v1/tax/transactions/{id}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<TransactionLineItem> ListLineItemsAutoPaging(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TransactionLineItem>($"/v1/tax/transactions/{id}/line_items", options, requestOptions);
        }

        public virtual IAsyncEnumerable<TransactionLineItem> ListLineItemsAutoPagingAsync(string id, TransactionListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TransactionLineItem>($"/v1/tax/transactions/{id}/line_items", options, requestOptions, cancellationToken);
        }
    }
}
