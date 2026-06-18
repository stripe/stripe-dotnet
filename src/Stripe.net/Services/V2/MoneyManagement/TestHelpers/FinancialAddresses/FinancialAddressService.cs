// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.TestHelpers
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FinancialAddressService : Service
    {
        internal FinancialAddressService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal FinancialAddressService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Simulate debiting a FinancialAddress in a Sandbox environment. This can be used to
        /// remove virtual funds and decrease your balance for testing.
        /// </summary>
        public virtual V2.MoneyManagement.FinancialAddressDebitSimulation Debit(string id, FinancialAddressDebitOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.MoneyManagement.FinancialAddressDebitSimulation>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/test_helpers/financial_addresses/{WebUtility.UrlEncode(id)}/debit", options, requestOptions);
        }

        /// <summary>
        /// Simulate debiting a FinancialAddress in a Sandbox environment. This can be used to
        /// remove virtual funds and decrease your balance for testing.
        /// </summary>
        public virtual Task<V2.MoneyManagement.FinancialAddressDebitSimulation> DebitAsync(string id, FinancialAddressDebitOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.MoneyManagement.FinancialAddressDebitSimulation>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/test_helpers/financial_addresses/{WebUtility.UrlEncode(id)}/debit", options, requestOptions, cancellationToken);
        }
    }
}
