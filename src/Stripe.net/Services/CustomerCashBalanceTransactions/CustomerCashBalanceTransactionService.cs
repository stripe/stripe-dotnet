// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerCashBalanceTransactionService : Service,
        INestedListable<CustomerCashBalanceTransaction, CustomerCashBalanceTransactionListOptions>,
        INestedRetrievable<CustomerCashBalanceTransaction, CustomerCashBalanceTransactionGetOptions>
    {
        public CustomerCashBalanceTransactionService()
        {
        }

        internal CustomerCashBalanceTransactionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerCashBalanceTransactionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a specific cash balance transaction, which updated the customer’s <a
        /// href="https://stripe.com/docs/payments/customer-balance">cash balance</a>.</p>.
        /// </summary>
        public virtual CustomerCashBalanceTransaction Get(string parentId, string id, CustomerCashBalanceTransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerCashBalanceTransaction>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/cash_balance_transactions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a specific cash balance transaction, which updated the customer’s <a
        /// href="https://stripe.com/docs/payments/customer-balance">cash balance</a>.</p>.
        /// </summary>
        public virtual Task<CustomerCashBalanceTransaction> GetAsync(string parentId, string id, CustomerCashBalanceTransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerCashBalanceTransaction>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/cash_balance_transactions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of transactions that modified the customer’s <a
        /// href="https://stripe.com/docs/payments/customer-balance">cash balance</a>.</p>.
        /// </summary>
        public virtual StripeList<CustomerCashBalanceTransaction> List(string parentId, CustomerCashBalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CustomerCashBalanceTransaction>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/cash_balance_transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of transactions that modified the customer’s <a
        /// href="https://stripe.com/docs/payments/customer-balance">cash balance</a>.</p>.
        /// </summary>
        public virtual Task<StripeList<CustomerCashBalanceTransaction>> ListAsync(string parentId, CustomerCashBalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CustomerCashBalanceTransaction>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/cash_balance_transactions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of transactions that modified the customer’s <a
        /// href="https://stripe.com/docs/payments/customer-balance">cash balance</a>.</p>.
        /// </summary>
        public virtual IEnumerable<CustomerCashBalanceTransaction> ListAutoPaging(string parentId, CustomerCashBalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CustomerCashBalanceTransaction>($"/v1/customers/{WebUtility.UrlEncode(parentId)}/cash_balance_transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of transactions that modified the customer’s <a
        /// href="https://stripe.com/docs/payments/customer-balance">cash balance</a>.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<CustomerCashBalanceTransaction> ListAutoPagingAsync(string parentId, CustomerCashBalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CustomerCashBalanceTransaction>($"/v1/customers/{WebUtility.UrlEncode(parentId)}/cash_balance_transactions", options, requestOptions, cancellationToken);
        }
    }
}
