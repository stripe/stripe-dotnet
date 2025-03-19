// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FinancingTransactionService : Service,
        IListable<FinancingTransaction, FinancingTransactionListOptions>,
        IRetrievable<FinancingTransaction, FinancingTransactionGetOptions>
    {
        public FinancingTransactionService()
        {
        }

        internal FinancingTransactionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public FinancingTransactionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a financing transaction for a financing offer.</p>.
        /// </summary>
        public virtual FinancingTransaction Get(string id, FinancingTransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancingTransaction>(BaseAddress.Api, HttpMethod.Get, $"/v1/capital/financing_transactions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a financing transaction for a financing offer.</p>.
        /// </summary>
        public virtual Task<FinancingTransaction> GetAsync(string id, FinancingTransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancingTransaction>(BaseAddress.Api, HttpMethod.Get, $"/v1/capital/financing_transactions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of financing transactions. The transactions are returned in sorted
        /// order, with the most recent transactions appearing first.</p>.
        /// </summary>
        public virtual StripeList<FinancingTransaction> List(FinancingTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<FinancingTransaction>>(BaseAddress.Api, HttpMethod.Get, $"/v1/capital/financing_transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of financing transactions. The transactions are returned in sorted
        /// order, with the most recent transactions appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<FinancingTransaction>> ListAsync(FinancingTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<FinancingTransaction>>(BaseAddress.Api, HttpMethod.Get, $"/v1/capital/financing_transactions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of financing transactions. The transactions are returned in sorted
        /// order, with the most recent transactions appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<FinancingTransaction> ListAutoPaging(FinancingTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FinancingTransaction>($"/v1/capital/financing_transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of financing transactions. The transactions are returned in sorted
        /// order, with the most recent transactions appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<FinancingTransaction> ListAutoPagingAsync(FinancingTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FinancingTransaction>($"/v1/capital/financing_transactions", options, requestOptions, cancellationToken);
        }
    }
}
