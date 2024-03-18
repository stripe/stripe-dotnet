// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerService : Service<Customer>
    {
        public CustomerService()
        {
        }

        public CustomerService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/test_helpers/customers";

        /// <summary>
        /// <p>Create an incoming testmode bank transfer</p>.
        /// </summary>
        public virtual CustomerCashBalanceTransaction FundCashBalance(string id, CustomerFundCashBalanceOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerCashBalanceTransaction>(HttpMethod.Post, $"/v1/test_helpers/customers/{id}/fund_cash_balance", options, requestOptions);
        }

        /// <summary>
        /// <p>Create an incoming testmode bank transfer</p>.
        /// </summary>
        public virtual Task<CustomerCashBalanceTransaction> FundCashBalanceAsync(string id, CustomerFundCashBalanceOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerCashBalanceTransaction>(HttpMethod.Post, $"/v1/test_helpers/customers/{id}/fund_cash_balance", options, requestOptions, cancellationToken);
        }
    }
}
