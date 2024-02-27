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
            : base(null)
        {
        }

        public FinancingTransactionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/capital/financing_transactions";

        public virtual FinancingTransaction Get(string id, FinancingTransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FinancingTransaction>(HttpMethod.Get, $"/v1/capital/financing_transactions/{id}", options, requestOptions);
        }

        public virtual Task<FinancingTransaction> GetAsync(string id, FinancingTransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FinancingTransaction>(HttpMethod.Get, $"/v1/capital/financing_transactions/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<FinancingTransaction> List(FinancingTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<FinancingTransaction>>(HttpMethod.Get, $"/v1/capital/financing_transactions", options, requestOptions);
        }

        public virtual Task<StripeList<FinancingTransaction>> ListAsync(FinancingTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<FinancingTransaction>>(HttpMethod.Get, $"/v1/capital/financing_transactions", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<FinancingTransaction> ListAutoPaging(FinancingTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FinancingTransaction>($"/v1/capital/financing_transactions", options, requestOptions);
        }

        public virtual IAsyncEnumerable<FinancingTransaction> ListAutoPagingAsync(FinancingTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FinancingTransaction>($"/v1/capital/financing_transactions", options, requestOptions, cancellationToken);
        }
    }
}
