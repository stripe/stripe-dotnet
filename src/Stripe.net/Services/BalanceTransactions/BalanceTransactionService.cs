// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class BalanceTransactionService : Service<BalanceTransaction>,
        IListable<BalanceTransaction, BalanceTransactionListOptions>,
        IRetrievable<BalanceTransaction, BalanceTransactionGetOptions>
    {
        public BalanceTransactionService()
        {
        }

        public BalanceTransactionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/balance_transactions";

        /// <summary>
        /// <p>Retrieves the balance transaction with the given ID.</p>.
        ///
        /// <p>Note that this endpoint previously used the path <c>/v1/balance/history/:id</c>.</p>.
        /// </summary>
        public virtual BalanceTransaction Get(string id, BalanceTransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BalanceTransaction>(HttpMethod.Get, $"/v1/balance_transactions/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the balance transaction with the given ID.</p>.
        ///
        /// <p>Note that this endpoint previously used the path <c>/v1/balance/history/:id</c>.</p>.
        /// </summary>
        public virtual Task<BalanceTransaction> GetAsync(string id, BalanceTransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BalanceTransaction>(HttpMethod.Get, $"/v1/balance_transactions/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of transactions that have contributed to the Stripe account balance
        /// (e.g., charges, transfers, and so forth). The transactions are returned in sorted order,
        /// with the most recent transactions appearing first.</p>.
        ///
        /// <p>Note that this endpoint was previously called “Balance history” and used the path
        /// <c>/v1/balance/history</c>.</p>.
        /// </summary>
        public virtual StripeList<BalanceTransaction> List(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<BalanceTransaction>>(HttpMethod.Get, $"/v1/balance_transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of transactions that have contributed to the Stripe account balance
        /// (e.g., charges, transfers, and so forth). The transactions are returned in sorted order,
        /// with the most recent transactions appearing first.</p>.
        ///
        /// <p>Note that this endpoint was previously called “Balance history” and used the path
        /// <c>/v1/balance/history</c>.</p>.
        /// </summary>
        public virtual Task<StripeList<BalanceTransaction>> ListAsync(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<BalanceTransaction>>(HttpMethod.Get, $"/v1/balance_transactions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of transactions that have contributed to the Stripe account balance
        /// (e.g., charges, transfers, and so forth). The transactions are returned in sorted order,
        /// with the most recent transactions appearing first.</p>.
        ///
        /// <p>Note that this endpoint was previously called “Balance history” and used the path
        /// <c>/v1/balance/history</c>.</p>.
        /// </summary>
        public virtual IEnumerable<BalanceTransaction> ListAutoPaging(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<BalanceTransaction>($"/v1/balance_transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of transactions that have contributed to the Stripe account balance
        /// (e.g., charges, transfers, and so forth). The transactions are returned in sorted order,
        /// with the most recent transactions appearing first.</p>.
        ///
        /// <p>Note that this endpoint was previously called “Balance history” and used the path
        /// <c>/v1/balance/history</c>.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<BalanceTransaction> ListAutoPagingAsync(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<BalanceTransaction>($"/v1/balance_transactions", options, requestOptions, cancellationToken);
        }
    }
}
