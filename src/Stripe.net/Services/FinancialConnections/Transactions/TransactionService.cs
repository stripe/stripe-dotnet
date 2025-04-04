// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransactionService : Service,
        IListable<Transaction, TransactionListOptions>,
        IRetrievable<Transaction, TransactionGetOptions>
    {
        public TransactionService()
        {
        }

        internal TransactionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public TransactionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves the details of a Financial Connections <c>Transaction</c></p>.
        /// </summary>
        public virtual Transaction Get(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/transactions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a Financial Connections <c>Transaction</c></p>.
        /// </summary>
        public virtual Task<Transaction> GetAsync(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/transactions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Transaction</c> objects.</p>.
        /// </summary>
        public virtual StripeList<Transaction> List(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Transaction>>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Financial Connections <c>Transaction</c> objects.</p>.
        /// </summary>
        public virtual Task<StripeList<Transaction>> ListAsync(TransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Transaction>>(BaseAddress.Api, HttpMethod.Get, $"/v1/financial_connections/transactions", options, requestOptions, cancellationToken);
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
