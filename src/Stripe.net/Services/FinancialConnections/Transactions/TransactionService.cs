// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransactionService : Service<Transaction>,
        IListable<Transaction, TransactionListOptions>,
        IRetrievable<Transaction, TransactionGetOptions>
    {
        public TransactionService()
        {
        }

        public TransactionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/financial_connections/transactions";

        /// <summary>
        /// <p>Retrieves the details of a Financial Connections <c>Transaction</c></p>.
        /// </summary>
        public virtual Transaction Get(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(HttpMethod.Get, $"/v1/financial_connections/transactions/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a Financial Connections <c>Transaction</c></p>.
        /// </summary>
        public virtual Task<Transaction> GetAsync(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(HttpMethod.Get, $"/v1/financial_connections/transactions/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Transaction</c> objects.</p>.
        /// </summary>
        public virtual StripeList<Transaction> List(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Transaction>>(HttpMethod.Get, $"/v1/financial_connections/transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Transaction</c> objects.</p>.
        /// </summary>
        public virtual Task<StripeList<Transaction>> ListAsync(TransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Transaction>>(HttpMethod.Get, $"/v1/financial_connections/transactions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Transaction</c> objects.</p>.
        /// </summary>
        public virtual IEnumerable<Transaction> ListAutoPaging(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Transaction>($"/v1/financial_connections/transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Transaction</c> objects.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Transaction> ListAutoPagingAsync(TransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Transaction>($"/v1/financial_connections/transactions", options, requestOptions, cancellationToken);
        }
    }
}
