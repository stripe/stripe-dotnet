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
        {
        }

        public TransactionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/gift_cards/transactions";

        /// <summary>
        /// <p>Cancel a gift card transaction</p>.
        /// </summary>
        public virtual Transaction Cancel(string id, TransactionCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/transactions/{id}/cancel", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Cancel a gift card transaction</p>.
        /// </summary>
        public virtual Task<Transaction> CancelAsync(string id, TransactionCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/transactions/{id}/cancel", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Confirm a gift card transaction</p>.
        /// </summary>
        public virtual Transaction Confirm(string id, TransactionConfirmOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/transactions/{id}/confirm", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Confirm a gift card transaction</p>.
        /// </summary>
        public virtual Task<Transaction> ConfirmAsync(string id, TransactionConfirmOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/transactions/{id}/confirm", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Create a gift card transaction</p>.
        /// </summary>
        public virtual Transaction Create(TransactionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/transactions", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Create a gift card transaction</p>.
        /// </summary>
        public virtual Task<Transaction> CreateAsync(TransactionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/transactions", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the gift card transaction.</p>.
        /// </summary>
        public virtual Transaction Get(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(BaseAddress.Api, HttpMethod.Get, $"/v1/gift_cards/transactions/{id}", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Retrieves the gift card transaction.</p>.
        /// </summary>
        public virtual Task<Transaction> GetAsync(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(BaseAddress.Api, HttpMethod.Get, $"/v1/gift_cards/transactions/{id}", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>List gift card transactions for a gift card</p>.
        /// </summary>
        public virtual StripeList<Transaction> List(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Transaction>>(BaseAddress.Api, HttpMethod.Get, $"/v1/gift_cards/transactions", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>List gift card transactions for a gift card</p>.
        /// </summary>
        public virtual Task<StripeList<Transaction>> ListAsync(TransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Transaction>>(BaseAddress.Api, HttpMethod.Get, $"/v1/gift_cards/transactions", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>List gift card transactions for a gift card</p>.
        /// </summary>
        public virtual IEnumerable<Transaction> ListAutoPaging(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Transaction>($"/v1/gift_cards/transactions", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>List gift card transactions for a gift card</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Transaction> ListAutoPagingAsync(TransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Transaction>($"/v1/gift_cards/transactions", options, requestOptions, ApiMode.V1, cancellationToken);
        }

        /// <summary>
        /// <p>Update a gift card transaction</p>.
        /// </summary>
        public virtual Transaction Update(string id, TransactionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/transactions/{id}", options, requestOptions, ApiMode.V1);
        }

        /// <summary>
        /// <p>Update a gift card transaction</p>.
        /// </summary>
        public virtual Task<Transaction> UpdateAsync(string id, TransactionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/gift_cards/transactions/{id}", options, requestOptions, ApiMode.V1, cancellationToken);
        }
    }
}
