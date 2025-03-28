// File generated from our OpenAPI spec
namespace Stripe.V2.TestHelpers
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
        /// Simulate crediting a FinancialAddress in a Sandbox environment. This can be used to add
        /// virtual funds and increase your balance for testing.
        /// </summary>
        public virtual V2.FinancialAddressCreditSimulation Credit(string id, FinancialAddressCreditOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.FinancialAddressCreditSimulation>(BaseAddress.Api, HttpMethod.Post, $"/v2/test_helpers/financial_addresses/{WebUtility.UrlEncode(id)}/credit", options, requestOptions);
        }

        /// <summary>
        /// Simulate crediting a FinancialAddress in a Sandbox environment. This can be used to add
        /// virtual funds and increase your balance for testing.
        /// </summary>
        public virtual Task<V2.FinancialAddressCreditSimulation> CreditAsync(string id, FinancialAddressCreditOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.FinancialAddressCreditSimulation>(BaseAddress.Api, HttpMethod.Post, $"/v2/test_helpers/financial_addresses/{WebUtility.UrlEncode(id)}/credit", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Generates microdeposits for a FinancialAddress in a Sandbox environment.
        /// </summary>
        public virtual V2.FinancialAddressGeneratedMicrodeposits GenerateMicrodeposits(string id, FinancialAddressGenerateMicrodepositsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.FinancialAddressGeneratedMicrodeposits>(BaseAddress.Api, HttpMethod.Post, $"/v2/test_helpers/financial_addresses/{WebUtility.UrlEncode(id)}/generate_microdeposits", options, requestOptions);
        }

        /// <summary>
        /// Generates microdeposits for a FinancialAddress in a Sandbox environment.
        /// </summary>
        public virtual Task<V2.FinancialAddressGeneratedMicrodeposits> GenerateMicrodepositsAsync(string id, FinancialAddressGenerateMicrodepositsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.FinancialAddressGeneratedMicrodeposits>(BaseAddress.Api, HttpMethod.Post, $"/v2/test_helpers/financial_addresses/{WebUtility.UrlEncode(id)}/generate_microdeposits", options, requestOptions, cancellationToken);
        }
    }
}
