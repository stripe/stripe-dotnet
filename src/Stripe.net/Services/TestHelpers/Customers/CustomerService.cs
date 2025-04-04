// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerService : Service
    {
        public CustomerService()
        {
        }

        internal CustomerService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Create an incoming testmode bank transfer</p>.
        /// </summary>
        public virtual CustomerCashBalanceTransaction FundCashBalance(string id, CustomerFundCashBalanceOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CustomerCashBalanceTransaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/customers/{WebUtility.UrlEncode(id)}/fund_cash_balance", options, requestOptions);
        }

        /// <summary>
        /// <p>Create an incoming testmode bank transfer</p>.
        /// </summary>
        public virtual Task<CustomerCashBalanceTransaction> FundCashBalanceAsync(string id, CustomerFundCashBalanceOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CustomerCashBalanceTransaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/customers/{WebUtility.UrlEncode(id)}/fund_cash_balance", options, requestOptions, cancellationToken);
        }
    }
}
