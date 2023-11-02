// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerCashBalanceTransactionService : ServiceNested<CustomerCashBalanceTransaction>,
        INestedListable<CustomerCashBalanceTransaction, CustomerCashBalanceTransactionListOptions>,
        INestedRetrievable<CustomerCashBalanceTransaction, CustomerCashBalanceTransactionGetOptions>
    {
        public CustomerCashBalanceTransactionService()
            : base(null)
        {
        }

        public CustomerCashBalanceTransactionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/customers/{PARENT_ID}/cash_balance_transactions";

        public virtual CustomerCashBalanceTransaction Get(string parentId, string id, CustomerCashBalanceTransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerCashBalanceTransaction>(HttpMethod.Get, $"/v1/customers/{parentId}/cash_balance_transactions/{id}", options, requestOptions);
        }

        public virtual Task<CustomerCashBalanceTransaction> GetAsync(string parentId, string id, CustomerCashBalanceTransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerCashBalanceTransaction>(HttpMethod.Get, $"/v1/customers/{parentId}/cash_balance_transactions/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CustomerCashBalanceTransaction> List(string parentId, CustomerCashBalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CustomerCashBalanceTransaction>>(HttpMethod.Get, $"/v1/customers/{parentId}/cash_balance_transactions", options, requestOptions);
        }

        public virtual Task<StripeList<CustomerCashBalanceTransaction>> ListAsync(string parentId, CustomerCashBalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CustomerCashBalanceTransaction>>(HttpMethod.Get, $"/v1/customers/{parentId}/cash_balance_transactions", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CustomerCashBalanceTransaction> ListAutoPaging(string parentId, CustomerCashBalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CustomerCashBalanceTransaction>($"/v1/customers/{parentId}/cash_balance_transactions", options, requestOptions);
        }

        public virtual IAsyncEnumerable<CustomerCashBalanceTransaction> ListAutoPagingAsync(string parentId, CustomerCashBalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CustomerCashBalanceTransaction>($"/v1/customers/{parentId}/cash_balance_transactions", options, requestOptions, cancellationToken);
        }
    }
}
