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
            : base(null)
        {
        }

        public BalanceTransactionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/balance_transactions";

        public virtual BalanceTransaction Get(string id, BalanceTransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BalanceTransaction>(HttpMethod.Get, $"/v1/balance_transactions/{id}", options, requestOptions);
        }

        public virtual Task<BalanceTransaction> GetAsync(string id, BalanceTransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BalanceTransaction>(HttpMethod.Get, $"/v1/balance_transactions/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<BalanceTransaction> List(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<BalanceTransaction>>(HttpMethod.Get, $"/v1/balance_transactions", options, requestOptions);
        }

        public virtual Task<StripeList<BalanceTransaction>> ListAsync(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<BalanceTransaction>>(HttpMethod.Get, $"/v1/balance_transactions", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<BalanceTransaction> ListAutoPaging(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<BalanceTransaction>($"/v1/balance_transactions", options, requestOptions);
        }

        public virtual IAsyncEnumerable<BalanceTransaction> ListAutoPagingAsync(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<BalanceTransaction>($"/v1/balance_transactions", options, requestOptions, cancellationToken);
        }
    }
}
