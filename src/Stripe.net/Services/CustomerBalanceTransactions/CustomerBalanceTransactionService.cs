// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerBalanceTransactionService : Service,
        INestedCreatable<CustomerBalanceTransaction, CustomerBalanceTransactionCreateOptions>,
        INestedListable<CustomerBalanceTransaction, CustomerBalanceTransactionListOptions>,
        INestedRetrievable<CustomerBalanceTransaction, CustomerBalanceTransactionGetOptions>,
        INestedUpdatable<CustomerBalanceTransaction, CustomerBalanceTransactionUpdateOptions>
    {
        public CustomerBalanceTransactionService()
        {
        }

        internal CustomerBalanceTransactionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerBalanceTransactionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates an immutable transaction that updates the customer’s credit <a
        /// href="https://stripe.com/docs/billing/customer/balance">balance</a>.</p>.
        /// </summary>
        public virtual CustomerBalanceTransaction Create(string parentId, CustomerBalanceTransactionCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerBalanceTransaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/balance_transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates an immutable transaction that updates the customer’s credit <a
        /// href="https://stripe.com/docs/billing/customer/balance">balance</a>.</p>.
        /// </summary>
        public virtual Task<CustomerBalanceTransaction> CreateAsync(string parentId, CustomerBalanceTransactionCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerBalanceTransaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/balance_transactions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a specific customer balance transaction that updated the customer’s <a
        /// href="https://stripe.com/docs/billing/customer/balance">balances</a>.</p>.
        /// </summary>
        public virtual CustomerBalanceTransaction Get(string parentId, string id, CustomerBalanceTransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerBalanceTransaction>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/balance_transactions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a specific customer balance transaction that updated the customer’s <a
        /// href="https://stripe.com/docs/billing/customer/balance">balances</a>.</p>.
        /// </summary>
        public virtual Task<CustomerBalanceTransaction> GetAsync(string parentId, string id, CustomerBalanceTransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerBalanceTransaction>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/balance_transactions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of transactions that updated the customer’s <a
        /// href="https://stripe.com/docs/billing/customer/balance">balances</a>.</p>.
        /// </summary>
        public virtual StripeList<CustomerBalanceTransaction> List(string parentId, CustomerBalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CustomerBalanceTransaction>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/balance_transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of transactions that updated the customer’s <a
        /// href="https://stripe.com/docs/billing/customer/balance">balances</a>.</p>.
        /// </summary>
        public virtual Task<StripeList<CustomerBalanceTransaction>> ListAsync(string parentId, CustomerBalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CustomerBalanceTransaction>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/balance_transactions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of transactions that updated the customer’s <a
        /// href="https://stripe.com/docs/billing/customer/balance">balances</a>.</p>.
        /// </summary>
        public virtual IEnumerable<CustomerBalanceTransaction> ListAutoPaging(string parentId, CustomerBalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CustomerBalanceTransaction>($"/v1/customers/{WebUtility.UrlEncode(parentId)}/balance_transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of transactions that updated the customer’s <a
        /// href="https://stripe.com/docs/billing/customer/balance">balances</a>.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<CustomerBalanceTransaction> ListAutoPagingAsync(string parentId, CustomerBalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CustomerBalanceTransaction>($"/v1/customers/{WebUtility.UrlEncode(parentId)}/balance_transactions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Most credit balance transaction fields are immutable, but you may update its
        /// <c>description</c> and <c>metadata</c>.</p>.
        /// </summary>
        public virtual CustomerBalanceTransaction Update(string parentId, string id, CustomerBalanceTransactionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerBalanceTransaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/balance_transactions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Most credit balance transaction fields are immutable, but you may update its
        /// <c>description</c> and <c>metadata</c>.</p>.
        /// </summary>
        public virtual Task<CustomerBalanceTransaction> UpdateAsync(string parentId, string id, CustomerBalanceTransactionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerBalanceTransaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/balance_transactions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
