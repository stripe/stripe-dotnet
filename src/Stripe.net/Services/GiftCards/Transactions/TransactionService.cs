// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransactionService : Service<Transaction>,
        ICreatable<Transaction, TransactionCreateOptions>,
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

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/gift_cards/transactions";

        public virtual Transaction Cancel(string id, TransactionCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(HttpMethod.Post, $"/v1/gift_cards/transactions/{id}/cancel", options, requestOptions);
        }

        public virtual Task<Transaction> CancelAsync(string id, TransactionCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(HttpMethod.Post, $"/v1/gift_cards/transactions/{id}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual Transaction Confirm(string id, TransactionConfirmOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(HttpMethod.Post, $"/v1/gift_cards/transactions/{id}/confirm", options, requestOptions);
        }

        public virtual Task<Transaction> ConfirmAsync(string id, TransactionConfirmOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(HttpMethod.Post, $"/v1/gift_cards/transactions/{id}/confirm", options, requestOptions, cancellationToken);
        }

        public virtual Transaction Create(TransactionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(HttpMethod.Post, $"/v1/gift_cards/transactions", options, requestOptions);
        }

        public virtual Task<Transaction> CreateAsync(TransactionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(HttpMethod.Post, $"/v1/gift_cards/transactions", options, requestOptions, cancellationToken);
        }

        public virtual Transaction Get(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(HttpMethod.Get, $"/v1/gift_cards/transactions/{id}", options, requestOptions);
        }

        public virtual Task<Transaction> GetAsync(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(HttpMethod.Get, $"/v1/gift_cards/transactions/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Transaction> List(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Transaction>>(HttpMethod.Get, $"/v1/gift_cards/transactions", options, requestOptions);
        }

        public virtual Task<StripeList<Transaction>> ListAsync(TransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Transaction>>(HttpMethod.Get, $"/v1/gift_cards/transactions", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Transaction> ListAutoPaging(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Transaction>($"/v1/gift_cards/transactions", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Transaction> ListAutoPagingAsync(TransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Transaction>($"/v1/gift_cards/transactions", options, requestOptions, cancellationToken);
        }

        public virtual Transaction Update(string id, TransactionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(HttpMethod.Post, $"/v1/gift_cards/transactions/{id}", options, requestOptions);
        }

        public virtual Task<Transaction> UpdateAsync(string id, TransactionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(HttpMethod.Post, $"/v1/gift_cards/transactions/{id}", options, requestOptions, cancellationToken);
        }
    }
}
