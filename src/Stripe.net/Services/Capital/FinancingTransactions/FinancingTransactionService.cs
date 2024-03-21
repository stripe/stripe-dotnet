// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FinancingTransactionService : Service<FinancingTransaction>,
        IListable<FinancingTransaction, FinancingTransactionListOptions>,
        IRetrievable<FinancingTransaction, FinancingTransactionGetOptions>
    {
        public FinancingTransactionService()
        {
        }

        public FinancingTransactionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/capital/financing_transactions";

        /// <summary>
        /// <p>Retrieves a financing transaction for a financing offer.</p>.
        /// </summary>
        public virtual FinancingTransaction Get(string id, FinancingTransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancingTransaction>(HttpMethod.Get, $"/v1/capital/financing_transactions/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a financing transaction for a financing offer.</p>.
        /// </summary>
        public virtual Task<FinancingTransaction> GetAsync(string id, FinancingTransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancingTransaction>(HttpMethod.Get, $"/v1/capital/financing_transactions/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of financing transactions. The transactions are returned in sorted
        /// order, with the most recent transactions appearing first.</p>.
        /// </summary>
        public virtual StripeList<FinancingTransaction> List(FinancingTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<FinancingTransaction>>(HttpMethod.Get, $"/v1/capital/financing_transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of financing transactions. The transactions are returned in sorted
        /// order, with the most recent transactions appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<FinancingTransaction>> ListAsync(FinancingTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<FinancingTransaction>>(HttpMethod.Get, $"/v1/capital/financing_transactions", options, requestOptions, cancellationToken);
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
