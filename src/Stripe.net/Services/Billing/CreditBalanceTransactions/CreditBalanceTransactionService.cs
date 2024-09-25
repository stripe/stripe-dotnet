// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreditBalanceTransactionService : Service<CreditBalanceTransaction>,
        IListable<CreditBalanceTransaction, CreditBalanceTransactionListOptions>,
        IRetrievable<CreditBalanceTransaction, CreditBalanceTransactionGetOptions>
    {
        public CreditBalanceTransactionService()
        {
        }

        public CreditBalanceTransactionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/billing/credit_balance_transactions";

        /// <summary>
        /// <p>Retrieves a credit balance transaction</p>.
        /// </summary>
        public virtual CreditBalanceTransaction Get(string id, CreditBalanceTransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditBalanceTransaction>(HttpMethod.Get, $"/v1/billing/credit_balance_transactions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a credit balance transaction</p>.
        /// </summary>
        public virtual Task<CreditBalanceTransaction> GetAsync(string id, CreditBalanceTransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditBalanceTransaction>(HttpMethod.Get, $"/v1/billing/credit_balance_transactions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of credit balance transactions</p>.
        /// </summary>
        public virtual StripeList<CreditBalanceTransaction> List(CreditBalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CreditBalanceTransaction>>(HttpMethod.Get, $"/v1/billing/credit_balance_transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of credit balance transactions</p>.
        /// </summary>
        public virtual Task<StripeList<CreditBalanceTransaction>> ListAsync(CreditBalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditBalanceTransaction>>(HttpMethod.Get, $"/v1/billing/credit_balance_transactions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a list of credit balance transactions</p>.
        /// </summary>
        public virtual IEnumerable<CreditBalanceTransaction> ListAutoPaging(CreditBalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CreditBalanceTransaction>($"/v1/billing/credit_balance_transactions", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a list of credit balance transactions</p>.
        /// </summary>
        public virtual IAsyncEnumerable<CreditBalanceTransaction> ListAutoPagingAsync(CreditBalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CreditBalanceTransaction>($"/v1/billing/credit_balance_transactions", options, requestOptions, cancellationToken);
        }
    }
}
