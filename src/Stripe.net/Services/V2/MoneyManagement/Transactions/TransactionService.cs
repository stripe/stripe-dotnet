// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransactionService : Service
    {
        internal TransactionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TransactionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves the details of a Transaction by ID.
        /// </summary>
        public virtual Transaction Get(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/transactions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of a Transaction by ID.
        /// </summary>
        public virtual Task<Transaction> GetAsync(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/transactions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of Transactions that match the provided filters.
        /// </summary>
        public virtual V2.StripeList<Transaction> List(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Transaction>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/transactions", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of Transactions that match the provided filters.
        /// </summary>
        public virtual Task<V2.StripeList<Transaction>> ListAsync(TransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Transaction>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/transactions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of Transactions that match the provided filters.
        /// </summary>
        public virtual IEnumerable<Transaction> ListAutoPaging(TransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Transaction>($"/v2/money_management/transactions", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of Transactions that match the provided filters.
        /// </summary>
        public virtual IAsyncEnumerable<Transaction> ListAutoPagingAsync(TransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Transaction>($"/v2/money_management/transactions", options, requestOptions, cancellationToken);
        }
    }
}
